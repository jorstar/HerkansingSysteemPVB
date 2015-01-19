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
        //List<Student> stud = (from u in ef.Student
        //                      where u.WACHTWOORD == null
        //                      select u).ToList();
        //foreach (Student s in stud)
        //{
        //    string user = s.LRL_NR;
        //    string pass = Functies.CalculateHashedPassword("ROCvT", user);
        //    s.WACHTWOORD = pass;
        //    ef.SaveChanges();
        //}

        if (Session["Role"] != null)
        {
            Response.Redirect("Home.aspx");
        }

    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            string user = tbGebruikersnaam.Text.ToUpper();
            string passwd = Functies.CalculateHashedPassword(tbWachtwoord.Text, user);
            
            //beheerder Login
            var beheer = from b in ef.Beheerder
                         where b.Gebruikersnaam.ToUpper() == user && b.Wachtwoord == passwd
                         select b;
            if (beheer.Any())
            {
                Beheerder obj = beheer.First();
                
                string role = "B";
                Session["User"] = obj.Gebruikersnaam;
                Session["Role"] = role;

                tbGebruikersnaam.Text = "";
                tbWachtwoord.Text = "";
                Response.Redirect("Home.aspx");
            }
            else
            {
                //docent login
                var docent = from d in ef.Docent
                             where d.DocentID.ToUpper() == user && d.Wachtwoord == passwd
                             select d;
                if (docent.Any())
                {
                    Docent obj = (Docent)docent.First();

                    string role = "D";
                    Session["User"] = obj.DocentID;
                    Session["Role"] = role;

                    if (docent.First().FirstLogin == true)
                    {
                        Session["wwChange"] = true;
                        tbGebruikersnaam.Text = "";
                        tbWachtwoord.Text = "";
                        Response.Redirect("~/wachtwoordWijzigen.aspx");
                    }
                    else
                    {
                        tbGebruikersnaam.Text = "";
                        tbWachtwoord.Text = "";
                        Response.Redirect("~/Home.aspx");
                    }
                }
                else
                {
                    //Student Login
                    var student = from s in ef.Student
                                  where s.LRL_NR.ToUpper() == user && s.WACHTWOORD == passwd
                                  select s;
                    if (student.Any())
                    {
                        Student obj = (Student)student.First();
                        string role = "S";
                        Session["User"] = obj.LRL_NR;
                        Session["Role"] = role;

                        if (student.First().FirstLogin == true)
                        {
                            Session["wwChange"] = true;
                            tbGebruikersnaam.Text = "";
                            tbWachtwoord.Text = "";
                            Response.Redirect("~/wachtwoordWijzigen.aspx");
                        }
                        else
                        {
                            tbGebruikersnaam.Text = "";
                            tbWachtwoord.Text = "";

                            string page = Request.QueryString["page"];
                            if (page == "Bevestigen")
                            {
                                string guid = Request.QueryString["ID"];
                                Response.Redirect("mailbevestigen.aspx?herkansing=" + guid);
                            }
                            else
                            {
                                Response.Redirect("~/Home.aspx");
                            }
                        }
                        
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