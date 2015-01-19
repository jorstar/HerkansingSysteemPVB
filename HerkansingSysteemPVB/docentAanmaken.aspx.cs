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
    protected void btnBevestigen_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            herkansingDBEntities entity = new herkansingDBEntities();

            entity.Docent.Add(new Docent
            {
                Roepnaam = txtVoornaam.Text,
                Tussenvoegsel = txtTussenvoegsel.Text,
                Achternaam = txtAchternaam.Text,
                Email = txtEMail.Text,
                DocentID = txtAfkorting.Text,
                Wachtwoord = Functies.CalculateHashedPassword(txtWachtwoord.Text, txtAfkorting.Text)
            });

            entity.SaveChanges();

            Response.Redirect("docentAanmaken.aspx");
        }
    }
}