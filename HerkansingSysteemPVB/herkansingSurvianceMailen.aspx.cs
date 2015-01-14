using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    herkansingDBEntities ef = new herkansingDBEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        dgvKandidaten.DataSource = ef.GetAllStudentenHerk(11004);
        dgvKandidaten.DataBind();

        //labels vullen
        lblToetsTitel.Text = ef.GetHerkansingInfoHerk(11004).First().Toetsnaam.ToString();
        lblToetsID.Text = ef.GetHerkansingInfoHerk(11004).First().ToetsID.ToString();
        lblBeschrijving.Text = ef.GetHerkansingInfoHerk(11004).First().ToetsDescriptie.ToString();
        lblDatumTijd.Text = ef.GetHerkansingInfoHerk(11004).First().Datum.ToString() + " om " + ef.GetHerkansingInfoHerk(11004).First().BeginTijd.ToString();
        lblLengte.Text = ef.GetHerkansingInfoHerk(11004).First().Tijdsduur.ToString() + " Minuten";
        lblStudvan.Text = ef.GetHerkansingInfoHerk(11004).First().KlasIDofOpleidingsID.ToString();
        lblSurveillant.Text = ef.GetHerkansingInfoHerk(11004).First().Surveillant.ToString();
        lblVak.Text = ef.GetHerkansingInfoHerk(11004).First().VakNaam.ToString();
    }
}