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

        if (rdbVeranderDisplay.SelectedIndex == 0)
        {
            StudentHerkansingsLijst.DataSource = objHerkansing.VerkrijgAlleHerkansingenStudent(Userid).ToList();
            StudentHerkansingsLijst.DataBind();
        }
        else if (rdbVeranderDisplay.SelectedIndex == 1)
        {
            StudentHerkansingsLijst.DataSource = objHerkansing.VerkrijgBeschikbareHerkansingStudent(Userid).ToList();
            StudentHerkansingsLijst.DataBind();
        }
        else
        {
            StudentHerkansingsLijst.DataSource = objHerkansing.VerkrijgHistorieHerkansingenStudent(Userid).ToList();
            StudentHerkansingsLijst.DataBind();
        }


    }


}