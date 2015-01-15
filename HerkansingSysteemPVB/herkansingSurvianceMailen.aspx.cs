using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string toetsTitel = "";
    string toetsID = "";
    string Beschrijving = "";
    string Datum = "";
    string Tijd = "";
    string lengte = "";
    string studentenvan = "";
    string docentSurveillant = "";
    string vak = "";
    string lokaal = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        herkansingDBEntities ef = new herkansingDBEntities();
        //herkansing id
        int herkansingID = 11004;
        var herkinfo = ef.GetHerkansingInfoHerk(herkansingID).First();


        //datagridview vullen
        dgvKandidaten.DataSource = ef.GetAllStudentenHerk(herkansingID);
        dgvKandidaten.DataBind();


        //variable vullen
        toetsTitel = herkinfo.Toetsnaam;
        toetsID = herkinfo.ToetsID.ToString();
        Beschrijving = herkinfo.ToetsDescriptie;
        Datum = herkinfo.Datum.ToString();
        Tijd = herkinfo.BeginTijd.ToString();
        lengte = herkinfo.Tijdsduur.ToString();
        studentenvan = herkinfo.KlasIDofOpleidingsID;
        docentSurveillant = herkinfo.Surveillant;
        vak = herkinfo.VakNaam;
        lokaal = herkinfo.Lokaal;
        

        //labels vullen
        lblToetsTitel.Text = toetsTitel;
        lblToetsID.Text = toetsID;
        lblBeschrijving.Text = Beschrijving;
        lblDatumTijd.Text = Datum + " om " + Tijd;
        lblLengte.Text = lengte;
        lblStudvan.Text = studentenvan;
        lblSurveillant.Text = docentSurveillant;
        lblVak.Text = vak;
        lblLokaal.Text = lokaal;
    }
    protected void btnMail_Click(object sender, EventArgs e)
    {
        try
        {

            //string docent = Session["User"].ToString();
            string docent = "KMP01";

            herkansingDBEntities entity = new herkansingDBEntities();
            string surveillantemail = entity.GetSurveillantEmail(docentSurveillant).First();
            string docentemail = entity.GetDocentEmail(docent).First();
            MailMessage Message = new MailMessage();

            Message.From = new MailAddress(docentemail);
            Message.To.Add(new MailAddress(surveillantemail));
            Message.Subject = "Herkansing: " + toetsID + " - " + toetsTitel;
            Message.SubjectEncoding = Encoding.UTF8;

            Message.Body += "De volgende studenten hebben zich aangemeld voor de toets <br/> <hr/>";
            Message.Body += GridViewToHtml(dgvKandidaten);
            Message.Body += "<br/> <hr/>";
            Message.Body += "<table><tr><td>Toets Informatie:</td></tr>"
                + "<tr><td>Toets:</td><td>" + toetsTitel + "</td></tr>"
                + "<tr><td>Beschrijving:</td><td>" + Beschrijving + "</td></tr>"
                + "<tr><td>Datum:</td><td>" + Datum + "</td></tr>"
                + "<tr><td>Tijd:</td><td>" + Tijd + "</td></tr>"
                + "<tr><td>Tijdsduur:</td><td>" + lengte + " Minuten</td></tr>"
                + "<tr><td>Studenten Van:</td><td>" + studentenvan + "</td></tr>"
                + "<tr><td>Lokaal:</td><td>" + lokaal + "</td></tr></table>";

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
    private string GridViewToHtml(GridView gv)
    {
        StringBuilder sb = new StringBuilder();
        StringWriter sw = new StringWriter(sb);
        HtmlTextWriter hw = new HtmlTextWriter(sw);
        gv.RenderControl(hw);
        return sb.ToString();
    }
    public override void VerifyRenderingInServerForm(Control control)
    {
        /* Verifies that the control is rendered */
    }
}