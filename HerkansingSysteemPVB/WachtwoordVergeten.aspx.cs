using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lblErrorMessage.Text = "";
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            herkansingDBEntities entity = new herkansingDBEntities();

            var beheer = from b in entity.Beheerder
                         where b.Gebruikersnaam.ToUpper() == tbGebruikersnaam.Text
                         select b;

            var docent = from d in entity.Docent
                         where d.DocentID.ToUpper() == tbGebruikersnaam.Text
                         select d;

            var student = from s in entity.Student
                          where s.LRL_NR.ToUpper() == tbGebruikersnaam.Text
                          select s;

            if (beheer.Any())
            {
                lblErrorMessage.Text = "•   Beheerders kunnen hun wachtwoord niet resetten.";
            }
            else if (docent.Any())
            {
                entity.setFirstLoginDocent(tbGebruikersnaam.Text);

                string objGuid = Guid.NewGuid().ToString("N");

                entity.wachtwoordVergetens.Add(new wachtwoordVergeten
                {
                    GUID = objGuid,
                    IsEenLeraar = true,
                    UserID = docent.First().DocentID,
                    Gebruikt = false
                });

                sendmail(objGuid, docent.First().Email);

                entity.SaveChanges();

            }
            else if (student.Any())
            {
                entity.setFirstLoginStudent(tbGebruikersnaam.Text);

                string objGuid = Guid.NewGuid().ToString("N");

                entity.wachtwoordVergetens.Add(new wachtwoordVergeten
                {
                    GUID = objGuid,
                    IsEenLeraar = false,
                    UserID = student.First().LRL_NR,
                    Gebruikt = false
                });

                sendmail(objGuid, student.First().EMAIL);

                entity.SaveChanges();

            }
        }
    }

    public void sendmail(string objGuid, string email)
    {
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
            MailTo = email;
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
        Message.Subject = "Wachtwoord wijzigen | " + tbGebruikersnaam.Text;
        Message.SubjectEncoding = Encoding.UTF8;

        Message.Body += "Bevestigings link (<html><body>Zo snel mogelijk: <a href=\""+ Adress + "wachtwoordWijzigen.aspx?Vergeten=" + objGuid + "\" target=\"_blank\">"+ Adress + "wachtwoordWijzigen.aspx?Vergeten=" + objGuid + "</a></body></html>";
        Message.IsBodyHtml = true;
        Message.BodyEncoding = Encoding.UTF8;
        NetworkCredential nc = new NetworkCredential();
        nc.UserName = MailServer;
        nc.Password = MailPassword;

        SmtpClient smtp = new SmtpClient(MailServer, MailPort);
        smtp.Credentials = nc;
        smtp.EnableSsl = true;
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtp.Send(Message);
        Session["HerkansingID"] = null;
    }
}