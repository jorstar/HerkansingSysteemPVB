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

        if (!Page.IsPostBack)
        {

            if (ddlHerkansingen.SelectedIndex == -1)
            {
                herkansingDBEntities entity = new herkansingDBEntities();
                ddlHerkansingen.DataSource = entity.GetAllAankomendeHerkansingenPlusInfo();
                ddlHerkansingen.DataValueField = "HerkansingID";
                ddlHerkansingen.DataTextField = "HerkansingID";
                ddlHerkansingen.DataBind();
            }

            

            if (ddlToetsen.SelectedIndex != -1)
            {
                herkansingDBEntities entity = new herkansingDBEntities();
                lblToetsNaam.Text = Convert.ToString(entity.GetToetsInfo(Convert.ToInt32(ddlToetsen.SelectedValue)).First().ToetsNaam);
                lblToetsVak.Text = Convert.ToString(entity.GetToetsInfo(Convert.ToInt32(ddlToetsen.SelectedValue)).First().VakNaam);
                lblToetsBeschrijving.Text = Convert.ToString(entity.GetToetsInfo(Convert.ToInt32(ddlToetsen.SelectedValue)).First().ToetsDescriptie);
                lblToetsID.Text = Convert.ToString(ddlToetsen.SelectedValue);
            }

        }

        if (rblKlasOfOpleiding.SelectedIndex == 0)
        {
            herkansingDBEntities entity = new herkansingDBEntities();
            ddlKlasOfOpleidingSelecteren.DataSource = entity.GetAllLokalen();
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

        if (ddlHerkansingen.SelectedIndex != -1)
        {
            FullTextboxen(Convert.ToInt32(ddlHerkansingen.SelectedValue));
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

}