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

        if (Session["Role"] == null)
        {

            Response.Redirect("login.aspx");

        }
        else
        {
            herkansingDBEntities entity = new herkansingDBEntities();

            Page.Title = string.Format("Welkom {0} {1}");

        }

    }
}