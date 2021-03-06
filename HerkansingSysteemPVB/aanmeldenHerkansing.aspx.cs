﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    int HerkID;
    string studID;
    protected void Page_Load(object sender, EventArgs e)
    {

        if ((string)Session["Role"] == "S")
        {
            if (Session["HerkansingID"] != null)
            {

                if (Functies.CheckWWChange(Convert.ToString(Session["User"]), Convert.ToString(Session["Role"])))
                {
                    Response.Redirect("wachtwoordWijzigen.aspx");
                }

                string HerkansingIDString = (string)Session["HerkansingID"];

                studID = Session["User"].ToString();
                HerkID = Convert.ToInt32(Session["HerkansingID"]);
                filllabels(studID, HerkID);
            }
            else
            {
                Response.Redirect("home.aspx");
            }
        }
        else
        {
            Response.Redirect("home.aspx");
        }        
    }
    protected void btnAanmelden_Click(object sender, EventArgs e)
    {
        try
        {
            herkansingDBEntities ef = new herkansingDBEntities();
            herkansingDBEntities ent = new herkansingDBEntities();
            //string Guid = Request.QueryString["Guid"];
            string objGuid = Guid.NewGuid().ToString("N");
            var herk = ef.getStudentHerkansingen(HerkID).First();
            var student = (from s in ef.Student
                           where s.LRL_NR == studID
                           select s).First();

            // nieuwe inschrijving
            Inschrijving objinsch = new Inschrijving();
            objinsch.HerkansingID = HerkID;
            objinsch.StudentID = studID;
            objinsch.BevestigingsID = objGuid;
            objinsch.Bevestigd = false;
            ent.Inschrijving.Add(objinsch);
            ent.SaveChanges();

            #region Mailvariabelen
            //Mail Variables
            string sitemode = ConfigurationManager.AppSettings["WebsiteMode"].ToString();
            string MailTo;
            string MailFrom;
            string MailUsername;
            string MailPassword;
            string MailServer;
            int MailPort;
            string Adress;
            if (sitemode.ToLower() == "live")
            {
                MailTo = student.EMAIL;
                MailFrom = ConfigurationManager.AppSettings["LiveMailEmail"].ToString();
                MailUsername = ConfigurationManager.AppSettings["LiveEmailUsername"].ToString();
                MailPassword = ConfigurationManager.AppSettings["LiveEmailPassword"].ToString();
                MailServer = ConfigurationManager.AppSettings["LiveEmailServer"].ToString();
                MailPort = Convert.ToInt16(ConfigurationManager.AppSettings["LiveEmailPort"]);
                Adress = ConfigurationManager.AppSettings["LiveAdres"].ToString();
            }
            else
            {
                MailTo = ConfigurationManager.AppSettings["DebugMailTo"].ToString();
                MailFrom = ConfigurationManager.AppSettings["DebugMailFrom"].ToString();
                MailUsername = ConfigurationManager.AppSettings["DebugEmailUsername"].ToString();
                MailPassword = ConfigurationManager.AppSettings["DebugEmailPassword"].ToString();
                MailServer = ConfigurationManager.AppSettings["DebugEmailServer"].ToString();
                MailPort = Convert.ToInt16(ConfigurationManager.AppSettings["DebugEmailPort"]);
                Adress = ConfigurationManager.AppSettings["DebugAdres"].ToString();
            }
            #endregion

            // send mail
            MailMessage Message = new MailMessage();

            Message.From = new MailAddress(MailFrom);
            Message.To.Add(new MailAddress(MailTo));
            Message.Subject = "Herkansing: " + herk.VakNaam + " - " + herk.Toets + "| Bevestiging";
            Message.SubjectEncoding = Encoding.UTF8;

            Message.Body += "<html><body style=\"padding: 0;margin: 0;font-family: Arial;\"><div style=\"height: 10px;\"></div><div style=\"width:80%;background-color: none;height: auto;margin: 50px auto;border: 2px #0072bc solid;\"><div style=\"text-align: center;padding: 10px 0;font-size: 25px;font-weight: bold;background-color: #A8B326;\">Herkansing bevestigen</div>"
            + "<div style=\"border-top: 2px dashed #0072bc;padding: 50px 35px 15px 35px;\"><div style=\"padding: 0 0 25px 35px;\">Herkansing informatie"
            + "</div><table><tr><td>Vak:</td><td>" + herk.VakNaam + "</td></tr><tr><td>Toets:</td><td>" + herk.Toets + "</td></tr>"
            + "<tr><td>Beschrijving:</td><td>" + herk.Beschrijving + "</td></tr><tr><td>Datum:</td><td>" + herk.Datum + " om " + herk.begintijd + "</td></tr>"
            + "<tr><td>Tijdsduur:</td><td>" + herk.Tijdsduur + "</td></tr><tr><td>Lokaal:</td><td>" + herk.Lokaal + "</td></tr>"
            + "<tr><td>Surveillant:</td><td>" + herk.surveillant + "</td></tr></table></div>"
            + "<div style=\"text-align: center;padding: 35px 0;font-style:oblique;\">Bevestigings link (Zo snel mogelijk: <a href=\"" + Adress + "mailbevestigen.aspx?herkansing=" + objGuid + "\" target=\"_blank\">" + Adress + "mailbevestigen.aspx?herkansing=" + objGuid + "</a></div></div></body></html>";
            Message.IsBodyHtml = true;
            Message.BodyEncoding = Encoding.UTF8;
            NetworkCredential nc = new NetworkCredential();
            nc.UserName = MailUsername;
            nc.Password = MailPassword;

            SmtpClient smtp = new SmtpClient(MailServer, MailPort);
            smtp.Credentials = nc;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Send(Message);
            Session["HerkansingID"] = null;

            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "<script>alert('Aanmelding gelukt, De bevestigings mail is verstuurd.');window.location.href='alleHerkansingenStudent.aspx'</script>");

        }
        catch (DuplicateNameException)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('U mag zich niet twee keer voor dezelfde toets aanmelden');", true);
        }
        catch (UpdateException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (SmtpFailedRecipientsException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (SmtpFailedRecipientException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (SmtpException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (EntityException ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
        catch (Exception ex)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + ex.Message + "');", true);
        }
    }
    private void filllabels(string studid, int herkid)
    {
        herkansingDBEntities ef = new herkansingDBEntities();
        var herk = ef.getStudentHerkansingen(herkid).First();
        lblBeschrijving.Text = herk.Beschrijving;
        lblDatum.Text = herk.Datum + " om " + herk.begintijd;
        lblLokaal.Text = herk.Lokaal;
        lblPlaatsen.Text = herk.plaatsen;
        lblSurveillant.Text = herk.surveillant;
        lblTijdsduur.Text = herk.Tijdsduur;
        lblToets.Text = herk.Toets;
        lblvak.Text = herk.VakNaam;
    }
}