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



    }
    protected void btnBevestig_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {

            if (Session["Role"] == "B")
            {
                herkansingDBEntities entity = new herkansingDBEntities();

                
            }
            else if (Session["Role"] == "D")
            {
                herkansingDBEntities entity = new herkansingDBEntities();


            }
            else if (Session["Role"] == "S")
            {
                herkansingDBEntities entity = new herkansingDBEntities();


            }
            else
            {

            }
        }
    }
}