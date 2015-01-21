using System;
using System.Collections.Generic;
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
                    UserID = tbGebruikersnaam.Text,
                    Gebruikt = false
                });

                sendmail(objGuid);

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
                    UserID = tbGebruikersnaam.Text,
                    Gebruikt = false
                });

                sendmail(objGuid);

                entity.SaveChanges();

            }
        }
    }

    public void sendmail(string objGuid)
    {
        // send mail
        MailMessage Message = new MailMessage();

        Message.From = new MailAddress("rocvantwentepvb@gmail.com");
        Message.To.Add(new MailAddress("rocvantwentepvb@gmail.com"));
        Message.Subject = "Wachtwoord wijzigen | " + tbGebruikersnaam.Text;
        Message.SubjectEncoding = Encoding.UTF8;

        Message.Body += "Bevestigings link (<html><body>Zo snel mogelijk: <a href=\"http://herkansingroc.ddns.net/wachtwoordWijzigen.aspx?Vergeten=" + objGuid + "\" target=\"_blank\">http://herkansingroc.ddns.net/wachtwoordWijzigen.aspx?Vergeten=" + objGuid + "</a></body></html>";
        Message.IsBodyHtml = true;
        Message.BodyEncoding = Encoding.UTF8;
        NetworkCredential nc = new NetworkCredential();
        nc.UserName = "rocvantwentepvb@gmail.com";
        nc.Password = "KJI1337!";

        SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
        smtp.Credentials = nc;
        smtp.EnableSsl = true;
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtp.Send(Message);
        Session["HerkansingID"] = null;
    }
}