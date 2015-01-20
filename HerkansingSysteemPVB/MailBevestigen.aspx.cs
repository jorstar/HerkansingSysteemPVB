using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string userid;
    string Guid;
    string exception;
    string messagesucess;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Convert.ToString(Session["Role"]) != "S")
        {
            Response.Redirect("Home.aspx");
        }

        Guid = Request.QueryString["herkansing"];
        if (Session["User"] == null)
        {
            if (Guid != null)
            {
                Response.Redirect("login.aspx?page=Bevestigen&ID=" + Guid);
            }
            else
            {
                Response.Redirect("home.aspx");
            }
        }
        else
        {
            userid = Session["User"].ToString();
            
            
            herkansingDBEntities ef = new herkansingDBEntities();
            try
            {
                var temp = ef.GetHerkansingBevestiging(userid, Guid).First();
                if (temp != null)
                {
                    var info = temp;

                    if (info.aantal == 0)
                    {
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Er zijn geen plaatsen meer beschikbaar voor deze herkansing.');", true);
                        Response.Redirect("home.aspx");
                    }
                    else
                    {
                        lblbeschrijving.Text = info.ToetsDescriptie;
                        lbldatum.Text = info.Datum + " om " + info.BeginTijd;
                        lbllokaal.Text = info.Lokaal;
                        lblsurveillant.Text = info.Achternaam;
                        lbltijd.Text = info.Tijdsduur.ToString();
                        lbltoets.Text = info.ToetsNaam;
                        lblvak.Text = info.VakNaam;
                    }
                }
            }
            catch (EntityException ex)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('"+ ex.Message +"');", true);
            }
            catch (Exception)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Je bent al geregistreerd voor die toets');", true);

                Response.Redirect("home.aspx");
            }
            
        }
    }
    protected void btnBevestigen_Click(object sender, EventArgs e)
    {
        try
        {
            herkansingDBEntities ef = new herkansingDBEntities();
            var objins = from i in ef.Inschrijving
                         where i.StudentID == userid && i.BevestigingsID == Guid
                         select i;
            if (objins.Any())
            {
                Inschrijving ins = objins.First();
                ins.Bevestigd = true;
                ef.SaveChanges();

                messagesucess = "U bent Successvol aangemeld voor de herkansing.";
            }
        }
        catch (EntityCommandCompilationException ex)
        {
            exception = ex.Message;
        }
        catch (EntityCommandExecutionException ex)
        {
            exception = ex.Message;
        }
        catch (EntityException ex)
        {
            exception = ex.Message;
        }
        catch (Exception ex)
        {
            exception = ex.Message;
        }
        finally
        {
            if (exception != null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + exception + "');", true);
            }
            else if(messagesucess != null)
            {
                ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + messagesucess + "');", true);
                Response.Redirect("home.aspx");
            }
        }
    }
}