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

            lblAstrix.Text = "";
            lblErrorMessage.Text = "";

            herkansingDBEntities entity = new herkansingDBEntities();

            var objLokaal = from L in entity.Lokaal
                            where L.LokaalNr.ToUpper() == txtLokaalNaam.Text.ToUpper()
                            select L;

            if (!objLokaal.Any())
            {
                 entity.Lokaal.Add(new Lokaal { LokaalNr = txtLokaalNaam.Text, AantalPlaatsen = Convert.ToInt32(txtAantalPlaatsen.Text) });

                 entity.SaveChanges();

                 ClientScript.RegisterStartupScript(this.GetType(), "myalert", "<script>alert('Het lokaal is succesvol toegevoegd');window.location.href='lokaalToevoegen.aspx'</script>");
            }
            else
            {
                lblAstrix.Text = "*";
                lblErrorMessage.Text = "•    Dat lokaal staat al in de database!";
            }
        }
    }
}