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
        if (Convert.ToString(Session["Role"]) == null)
        {
            Response.Redirect("Home.aspx");
        }

    }
    protected void btnBevestig_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/home.aspx");
    }
    protected void btnAnnuleren_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('U bent succesvol uitgelogd.');", true);
        Response.Redirect("~/login.aspx");
    }
}