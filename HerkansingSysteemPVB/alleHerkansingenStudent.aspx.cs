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
        ////Session["userID"] = Userid;
        int Userid = 0015180;

        herkansingDBEntities objHerkansing = new herkansingDBEntities();

        StudentHerkansingsLijst.DataSource = objHerkansing.VerkrijgAlleHerkansingenStudent(Userid).ToList();
        StudentHerkansingsLijst.DataBind();
    }

    protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}