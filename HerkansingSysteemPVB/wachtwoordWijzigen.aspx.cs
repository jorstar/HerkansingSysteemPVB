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



    }
    protected void btnBevestig_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {

            if (Session["Role"] == null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Er ging iets mis, uw moet opnieuw inloggen.');", true);

                Session.Abandon();

                Response.Redirect("login.aspx");
            }
            else
            {
                if (Session["Role"] == "B")
                {
                    herkansingDBEntities entity = new herkansingDBEntities();

                    entity.wwChangeBeheer(
                        Functies.CalculateHashedPassword(txtOldPass.Text, Convert.ToString(Session["User"])),
                        Functies.CalculateHashedPassword(txtNewPass.Text, Convert.ToString(Session["User"])),
                        Convert.ToString(Session["User"])
                        );
                }
                else if (Session["Role"] == "D")
                {
                    herkansingDBEntities entity = new herkansingDBEntities();

                    entity.wwChangeDocent(
                        Functies.CalculateHashedPassword(txtOldPass.Text, Convert.ToString(Session["User"])),
                        Functies.CalculateHashedPassword(txtNewPass.Text, Convert.ToString(Session["User"])),
                        Convert.ToString(Session["User"])
                        );
                }
                else if (Session["Role"] == "S")
                {
                    herkansingDBEntities entity = new herkansingDBEntities();

                    entity.wwChangeStudent(
                        Functies.CalculateHashedPassword(txtOldPass.Text, Convert.ToString(Session["User"])),
                        Functies.CalculateHashedPassword(txtNewPass.Text, Convert.ToString(Session["User"])),
                        Convert.ToString(Session["User"])
                        );
                }
                else
                {
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Er ging iets mis, uw moet opnieuw inloggen.');", true);

                    Session.Abandon();

                    Response.Redirect("login.aspx");
                }
            }
        }
    }
}