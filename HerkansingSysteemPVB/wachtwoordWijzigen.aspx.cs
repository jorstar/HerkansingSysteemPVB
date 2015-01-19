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

        if (Convert.ToString(Session["Role"]) != "B" | Convert.ToString(Session["Role"]) != "D" | Convert.ToString(Session["Role"]) != "S")
        {
            Response.Redirect("Home.aspx");
        }

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

                    string user = Convert.ToString(Session["User"]).ToUpper();
                    string passwd = Functies.CalculateHashedPassword(txtOldPass.Text, user);

                    var objVar = from b in entity.Beheerder
                                 where b.Gebruikersnaam.ToUpper() == user && b.Wachtwoord == passwd
                                 select b;
                    if (objVar.Any())
                    {
                        entity.wwChangeBeheer(
                        Functies.CalculateHashedPassword(txtOldPass.Text, Convert.ToString(Session["User"])),
                        Functies.CalculateHashedPassword(txtNewPass.Text, Convert.ToString(Session["User"])),
                        Convert.ToString(Session["User"])
                        );

                        Session.Abandon();

                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Wachtwoord is gewijzigd.');", true);

                        Response.Redirect("login.aspx");
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Het oude wachtwoord was incorrect');", true);

                        txtOldPass.Text = "";
                        txtOldPass.Focus();
                    }
                }
                else if (Session["Role"] == "D")
                {
                    herkansingDBEntities entity = new herkansingDBEntities();

                    string user = Convert.ToString(Session["User"]).ToUpper();
                    string passwd = Functies.CalculateHashedPassword(txtOldPass.Text, user);

                    var objVar = from b in entity.Docent
                                 where b.DocentID.ToUpper() == user && b.Wachtwoord == passwd
                                 select b;
                    if (objVar.Any())
                    {
                        entity.wwChangeDocent(
                        Functies.CalculateHashedPassword(txtOldPass.Text, Convert.ToString(Session["User"])),
                        Functies.CalculateHashedPassword(txtNewPass.Text, Convert.ToString(Session["User"])),
                        Convert.ToString(Session["User"])
                        );

                        Session.Abandon();

                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Wachtwoord is gewijzigd.');", true);

                        Response.Redirect("login.aspx");
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Het oude wachtwoord was incorrect');", true);

                        txtOldPass.Text = "";
                        txtOldPass.Focus();
                    }
                }
                else if (Session["Role"] == "S")
                {
                    herkansingDBEntities entity = new herkansingDBEntities();

                    string user = Convert.ToString(Session["User"]).ToUpper();
                    string passwd = Functies.CalculateHashedPassword(txtOldPass.Text, user);

                    var objVar = from b in entity.Student
                                 where b.LRL_NR.ToUpper() == user && b.WACHTWOORD == passwd
                                 select b;
                    if (objVar.Any())
                    {
                        entity.wwChangeStudent(
                            Functies.CalculateHashedPassword(txtOldPass.Text, Convert.ToString(Session["User"])),
                            Functies.CalculateHashedPassword(txtNewPass.Text, Convert.ToString(Session["User"])),
                            Convert.ToString(Session["User"])
                            );

                        Session.Abandon();

                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Wachtwoord is gewijzigd.');", true);

                        Response.Redirect("login.aspx");
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Het oude wachtwoord was incorrect');", true);

                        txtOldPass.Text = "";
                        txtOldPass.Focus();
                    }
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