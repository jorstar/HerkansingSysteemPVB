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
       // string Guid = Request.QueryString["Guid"];
            
        DateTime day = DateTime.Now.AddDays(2);
    }
    protected void btnAanmelden_Click(object sender, EventArgs e)
    {
        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + Guid.NewGuid().ToString("N") + "');", true);
    }
}