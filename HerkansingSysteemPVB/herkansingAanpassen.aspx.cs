using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Convert.ToString(Session["Role"]) != "B")
        {
            Response.Redirect("Home.aspx");
        }

        if (!Page.IsPostBack)
        {
            //Toets DropDropList Vullen
            herkansingDBEntities entity = new herkansingDBEntities();
            ddlHerkansingen.DataSource = entity.GetAllAankomendeHerkansingenPlusInfo();
            ddlHerkansingen.DataValueField = "HerkansingID";
            ddlHerkansingen.DataTextField = "HerkansingID";
            ddlHerkansingen.DataBind();
            ddlHerkansingen.SelectedIndex = 0;

            ddlToetsen.DataSource = entity.GetAllToets();
            ddlToetsen.DataValueField = "toetsID";
            ddlToetsen.DataTextField = "toetsNaam";
            ddlToetsen.DataBind();

            ddlSureillance.DataSource = entity.GetAllSurveillance();
            ddlSureillance.DataTextField = "DocentInfo";
            ddlSureillance.DataValueField = "DocentID";
            ddlSureillance.DataBind();

            ddlLokaal.DataSource = entity.GetAllLokalen();
            ddlLokaal.DataBind();



            ddlKlasOfOpleidingSelecteren.SelectedValue = Convert.ToString(entity.GetHerkansingInfo(Convert.ToInt32(ddlHerkansingen.SelectedValue)).First().KlasIDofOpleidingsID);

            if (entity.GetHerkansingInfo(Convert.ToInt32(ddlHerkansingen.SelectedValue)).First().IsHetEenKlas)
            {
                rblKlasOfOpleiding.SelectedIndex = 0;
            }
            else
            {
                rblKlasOfOpleiding.SelectedIndex = 1;
            }

            //eventen af vuren
            ddlHerkansingen_SelectedIndexChanged(sender, e);
            rblKlasOfOpleiding_SelectedIndexChanged(sender, e);
        }




    }

    public void FullTextboxen(int HerkansingID_)
    {
        herkansingDBEntities entity = new herkansingDBEntities();

        txtDatum.Text = entity.GetHerkansingInfo(HerkansingID_).First().Datum.ToShortDateString();
        txtLengteHerkansing.Text = entity.GetHerkansingInfo(HerkansingID_).First().Tijdsduur.ToString();
        txtMaxPlaatsen.Text = entity.GetHerkansingInfo(HerkansingID_).First().Plaatsen.ToString();
        txtUur.Text = entity.GetHerkansingInfo(HerkansingID_).First().BeginTijd.ToString().Substring(0, 2);
        txtMinuten.Text = entity.GetHerkansingInfo(HerkansingID_).First().BeginTijd.ToString().Substring(3, 2);

        if (entity.GetHerkansingInfo(HerkansingID_).First().IsHetEenKlas)
        {
            rblKlasOfOpleiding.SelectedIndex = 0;
        }
        else
        {
            rblKlasOfOpleiding.SelectedIndex = 1;
        }

    }

    protected void btnBevestig_Click(object sender, EventArgs e)
    {
        herkansingDBEntities entity = new herkansingDBEntities();

        bool objBool;
        if (rblKlasOfOpleiding.SelectedIndex == 0)
        {
            objBool = true;
        }
        else
        {
            objBool = false;
        }

        entity.UpdateHerkansing(
            Convert.ToInt32(ddlHerkansingen.SelectedValue),
            ddlLokaal.SelectedValue,
            Convert.ToDateTime(txtDatum.Text),
            ddlSureillance.SelectedValue,
            Convert.ToInt32(ddlToetsen.SelectedValue),
            Convert.ToInt32(txtLengteHerkansing.Text),
            Convert.ToInt32(txtMaxPlaatsen.Text),
            cbActief.Checked, objBool,
            ddlKlasOfOpleidingSelecteren.SelectedValue,
            txtUur.Text + ":" + txtMinuten.Text
            );

        entity.SaveChanges();

        Response.Redirect("herkansingAanpassen.aspx");
    }
    protected void ddlHerkansingen_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (ddlSureillance.SelectedIndex != -1)
        {
            herkansingDBEntities entity = new herkansingDBEntities();

            ddlSureillance.SelectedValue = Convert.ToString(entity.GetHerkansingInfo(Convert.ToInt32(ddlHerkansingen.SelectedValue)).First().Surveillant);
            ddlLokaal.SelectedValue = Convert.ToString(entity.GetHerkansingInfo(Convert.ToInt32(ddlHerkansingen.SelectedValue)).First().Lokaal);
            FullTextboxen(Convert.ToInt32(ddlHerkansingen.SelectedValue));
            txtDatum.Text = entity.GetHerkansingInfo(Convert.ToInt32(ddlHerkansingen.SelectedValue)).First().Datum.ToString();
            cbActief.Checked = entity.GetHerkansingInfo(Convert.ToInt32(ddlHerkansingen.SelectedValue)).First().Actief;
            ddlToetsen.SelectedValue = Convert.ToString(entity.GetHerkansingInfo(Convert.ToInt32(ddlHerkansingen.SelectedValue)).First().Toets);
            ddlToetsen_SelectedIndexChanged(sender, e);
            rblKlasOfOpleiding_SelectedIndexChanged(sender, e);
        }
    }
    protected void ddlToetsen_SelectedIndexChanged(object sender, EventArgs e)
    {
        herkansingDBEntities entity = new herkansingDBEntities();
        lblToetsNaam.Text = entity.GetToetsInfo(Convert.ToInt32(ddlToetsen.SelectedValue)).First().ToetsNaam;
        lblToetsVak.Text = entity.GetToetsInfo(Convert.ToInt32(ddlToetsen.SelectedValue)).First().VakNaam;
        lblToetsBeschrijving.Text = entity.GetToetsInfo(Convert.ToInt32(ddlToetsen.SelectedValue)).First().ToetsDescriptie;
        lblToetsID.Text = Convert.ToString(entity.GetToetsInfo(Convert.ToInt32(ddlToetsen.SelectedValue)).First().ToetsID);
    }
    protected void rblKlasOfOpleiding_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rblKlasOfOpleiding.SelectedIndex == 0)
        {
            herkansingDBEntities entity = new herkansingDBEntities();
            ddlKlasOfOpleidingSelecteren.DataSource = entity.GetAllklassen();
            ddlKlasOfOpleidingSelecteren.DataBind();
        }
        else if (rblKlasOfOpleiding.SelectedIndex == 1)
        {
            herkansingDBEntities entity = new herkansingDBEntities();
            ddlKlasOfOpleidingSelecteren.DataSource = entity.GetAllopleidingen();
            ddlKlasOfOpleidingSelecteren.DataBind();

            ddlKlasOfOpleidingSelecteren.SelectedIndex = 0;
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Iets ging ergens fout.');", true);
        }
    }
}