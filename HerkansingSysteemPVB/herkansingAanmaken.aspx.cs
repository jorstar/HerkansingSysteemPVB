using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        Session["User"] = "WGS01";

        if (!Page.IsPostBack)
        {
            herkansingDBEntities entity = new herkansingDBEntities();

            ddlToetsen.DataSource = entity.GetAllToets();
            ddlToetsen.DataValueField = "toetsID";
            ddlToetsen.DataTextField = "toetsNaam";
            ddlToetsen.DataBind();

            ddlSureillance.DataSource = entity.GetAllSurveillance();
            ddlSureillance.DataTextField = "DocentInfo";
            ddlSureillance.DataValueField = "DocentID";
            ddlSureillance.DataBind();

            rblKlasOfOpleiding.SelectedIndex = 0;

            ddlLokaal.DataSource = entity.GetAllLokalen();
            ddlLokaal.DataBind();

        }

        if (rblKlasOfOpleiding.SelectedIndex == 0)
        {
            herkansingDBEntities entity = new herkansingDBEntities();
            ddlKlasOfOpleidingSelecteren.DataSource = entity.GetAllklassen();
            ddlKlasOfOpleidingSelecteren.DataBind();

        }
        else
        {
            herkansingDBEntities entity = new herkansingDBEntities();
            ddlKlasOfOpleidingSelecteren.DataSource = entity.GetAllopleidingen();
            ddlKlasOfOpleidingSelecteren.DataBind();
        }

        if (ddlToetsen.SelectedIndex != -1)
        {
            herkansingDBEntities entity = new herkansingDBEntities();

            lblToetsNaam.Text = Convert.ToString(entity.GetToetsInfo(Convert.ToInt32(ddlToetsen.SelectedValue)).First().ToetsNaam);
            lblToetsVak.Text = Convert.ToString(entity.GetToetsInfo(Convert.ToInt32(ddlToetsen.SelectedValue)).First().VakNaam);
            lblToetsBeschrijving.Text = Convert.ToString(entity.GetToetsInfo(Convert.ToInt32(ddlToetsen.SelectedValue)).First().ToetsDescriptie);
            lblToetsID.Text = Convert.ToString(ddlToetsen.SelectedValue);
        }

        SetTimeNow();

    }

    public void SetTimeNow()
    {
        if (txtUur.Text == "")
        {
            txtUur.Text = DateTime.Now.Hour.ToString();

        }
        if (txtMinuten.Text == "")
        {
            txtMinuten.Text = DateTime.Now.Minute.ToString();

        }
    }
    protected void btnBevestig_Click(object sender, EventArgs e)
    {

        if (Page.IsValid)
        {
            
            bool objBool;
            if(rblKlasOfOpleiding.SelectedIndex == 0)
            {
                objBool = true;
            }
            else{
                objBool = false;
            }

            herkansingDBEntities entity = new herkansingDBEntities();

            entity.Herkansing.Add(new Herkansing
            {
                Actief = true,
                Datum = Convert.ToDateTime(txtDatum.Text),
                Plaatsen = Convert.ToInt32(txtMaxPlaatsen.Text),
                Docent = Convert.ToString(Session["User"]),
                Lokaal = ddlLokaal.SelectedValue,
                IsHetEenKlas = objBool,
                KlasIDofOpleidingsID = ddlKlasOfOpleidingSelecteren.SelectedValue,
                Tijdsduur = Convert.ToInt32(txtMaxPlaatsen.Text),
                Toets = Convert.ToInt32(ddlToetsen.SelectedValue),
                Surveillant = ddlSureillance.SelectedValue

            });

            entity.SaveChanges();

            Response.Redirect("herkansingAanmaken.aspx");

        }

    }
}