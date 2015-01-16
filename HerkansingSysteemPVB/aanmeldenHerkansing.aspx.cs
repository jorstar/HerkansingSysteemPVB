using System;
using System.Collections.Generic;
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
        Session["User"] = "0178460";
        Session["HerkansingID"] = 11004;

        studID = Session["User"].ToString();
        HerkID = Convert.ToInt32(Session["HerkansingID"]);
        filllabels(studID, HerkID);
        Session["HerkansingID"] = null;
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
            

            // send mail
            string studentEmail = student.EMAIL;
            MailMessage Message = new MailMessage();

            Message.From = new MailAddress("rocvantwentepvb@gmail.com");
            Message.To.Add(new MailAddress("rocvantwentepvb@gmail.com"));
            Message.Subject = "Herkansing: " + herk.VakNaam + " - " + herk.Toets + "| Bevestiging";
            Message.SubjectEncoding = Encoding.UTF8;

            Message.Body += "<html><body style=\"padding: 0;margin: 0;font-family: Arial;\"><div style=\"height: 10px;\"></div><div style=\"width:80%;background-color: none;height: auto;margin: 50px auto;border: 2px #0072bc solid;\"><div style=\"text-align: center;padding: 10px 0;font-size: 25px;font-weight: bold;background-color: #A8B326;\">Herkansing bevestigen</div>"
            + "<div style=\"border-top: 2px dashed #0072bc;padding: 50px 35px 15px 35px;\"><div style=\"padding: 0 0 25px 35px;\">Herkansing informatie"
            + "</div><table><tr><td>Vak:</td><td>"+herk.VakNaam+"</td></tr><tr><td>Toets:</td><td>"+herk.Toets+"</td></tr>"
            + "<tr><td>Beschrijving:</td><td>"+ herk.Beschrijving + "</td></tr><tr><td>Datum:</td><td>"+herk.Datum + " om " + herk.begintijd +"</td></tr>"
            + "<tr><td>Tijdsduur:</td><td>"+ herk.Tijdsduur+ "</td></tr><tr><td>Lokaal:</td><td>"+herk.Lokaal+"</td></tr>"
            + "<tr><td>Surveillant:</td><td>"+herk.surveillant+"</td></tr></table></div>"
            + "<div style=\"text-align: center;padding: 35px 0;font-style:oblique;\">Bevestigings link (Zo snel mogelijk: <a href=\"http://127.0.0.1:8085/login.aspx\" target=\"_blank\">http://127.0.0.1:8085/login.aspx</a></div></div></body></html>";
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