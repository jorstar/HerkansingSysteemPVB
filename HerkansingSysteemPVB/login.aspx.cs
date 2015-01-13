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

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            string user = tbGebruikersnaam.Text;
            string passwd = Functies.CalculateHashedPassword(tbWachtwoord.Text, user);

            var beheer = ef.LoginBeheerder(user, passwd);
            if (beheer.Any())
            {
                string role = "B";
                Session["User"] = beheer.First();
                Session["Role"] = role;

                tbGebruikersnaam.Text = "";
                tbWachtwoord.Text = "";
                Response.Redirect("Home.aspx");
            }
            else
            {
                var docent = ef.LoginDocent(user, passwd);
                if (docent.Any())
                {
                    string role = "D";
                    Session["User"] = docent.First();
                    Session["Role"] = role;

                    tbGebruikersnaam.Text = "";
                    tbWachtwoord.Text = "";
                    Response.Redirect("Home.aspx");
                }
                else
                {
                    var student = ef.LoginStudent(user, passwd);
                    if (student.Any())
                    {
                        string role = "S";
                        Session["User"] = student.First();
                        Session["Role"] = role;

                        tbGebruikersnaam.Text = "";
                        tbWachtwoord.Text = "";
                        Response.Redirect("Home.aspx");
                    }
                    else
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Gebruikersnaam of wachtwoord is onjuist ingevoerd.');", true);
                        tbWachtwoord.Text = "";
                        tbWachtwoord.Focus();
                    }
                }
            }

        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
}