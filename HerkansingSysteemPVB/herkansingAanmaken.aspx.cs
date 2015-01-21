using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Globalization;

public partial class _Default : System.Web.UI.Page
{

    public int AantalBeschikbarePlaatsen;

    protected void Page_Load(object sender, EventArgs e)
    {

        if (Convert.ToString(Session["Role"]) == "D")
        {
            if (Functies.CheckWWChange(Convert.ToString(Session["User"]), Convert.ToString(Session["Role"])))
            {
                Response.Redirect("wachtwoordWijzigen.aspx");
            }
        }
        else
        {
            Response.Redirect("Home.aspx");
        }

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

            rblKlasOfOpleiding_SelectedIndexChanged(sender, e);
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
            if (DateTime.Now.Minute.ToString().Length == 2)
            {
                txtMinuten.Text = DateTime.Now.Minute.ToString(); 
            }
            else
            {
                txtMinuten.Text = "0" + DateTime.Now.Minute.ToString();
            }


        }
    }
    protected void btnBevestig_Click(object sender, EventArgs e)
    {
        
        if (ddlLokaal.SelectedIndex != -1)
        {
            herkansingDBEntities entity = new herkansingDBEntities();
            AantalBeschikbarePlaatsen = Convert.ToInt32(entity.GetAantalPlaatsenLokaal(ddlLokaal.SelectedValue.ToString()).First());    
        }
        
        if (Page.IsValid)
        {

            if (Convert.ToInt32(txtMaxPlaatsen.Text) <= AantalBeschikbarePlaatsen)
            {
                bool objBool;
                if (rblKlasOfOpleiding.SelectedIndex == 0)
                {
                    objBool = true;
                }
                else
                {
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
                    Surveillant = ddlSureillance.SelectedValue,
                    BeginTijd = txtUur.Text + ":" + txtMinuten.Text

                });

                entity.SaveChanges();

                Response.Redirect("herkansingAanmaken.aspx");
            }
            else
            {
                lblMaxAantalPlaatsen.Text = "Het maximum aantal plaatsen voor dat lokaal is " + AantalBeschikbarePlaatsen;
                lblAstrixAantalPlaatsen.Text = "*";
            }
        }

    }
    protected void txtUur_TextChanged(object sender, EventArgs e)
    {

        if (txtUur.Text.Length == 1)
        {
            txtUur.Text = "0" + txtUur.Text;
        }

    }
    protected void txtMinuten_TextChanged(object sender, EventArgs e)
    {
        if (txtMinuten.Text.Length == 1)
        {
            txtMinuten.Text = "0" + txtMinuten.Text;
        }
    }
    protected void rblKlasOfOpleiding_SelectedIndexChanged(object sender, EventArgs e)
    {

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

    }
}