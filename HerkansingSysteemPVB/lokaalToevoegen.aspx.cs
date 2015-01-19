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
    }
    protected void btnBevestig_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            herkansingDBEntities entity = new herkansingDBEntities();

            entity.Lokaal.Add(new Lokaal { LokaalNr = txtLokaalNaam.Text, AantalPlaatsen = Convert.ToInt32(txtAantalPlaatsen.Text) });

            entity.SaveChanges();
        }

        Response.Redirect("vakAanmaken.aspx");
    }
}