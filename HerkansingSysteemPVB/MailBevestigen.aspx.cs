using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string userid;
    string Guid;
    protected void Page_Load(object sender, EventArgs e)
    {
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

            var temp = ef.GetHerkansingBevestiging(userid, Guid);
            if (temp.Any())
            {
                var info = temp.First();

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
    }
    protected void btnBevestigen_Click(object sender, EventArgs e)
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

        }
    }
}