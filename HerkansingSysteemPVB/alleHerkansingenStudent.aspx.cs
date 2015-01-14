using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{

    public int Userid = 0015180; // verwijderen als de Session dingen zijn geregeld\\
    #region important stuffs
    public herkansingDBEntities objHerkansing = new herkansingDBEntities();
    public int rdbSelectedValue;
    #endregion
    protected void Page_Load(object sender, EventArgs e)
    {

        ////Session["userID"] = Userid;
        ////Sesssion[""] //moet een waarde krijgen voor de geselecteerde herkansing
        #region voor de radiobuttonlist
        SelectRadioButtonValue();
        rdbSelectedValue = rdbVeranderDisplay.SelectedIndex;

        if (rdbVeranderDisplay.SelectedIndex == 0)
        {
            StudentHerkansingsLijst.DataSource = objHerkansing.VerkrijgAlleHerkansingenStudent(Userid).ToList();
            StudentHerkansingsLijst.DataBind();
        }

        if (rdbVeranderDisplay.SelectedIndex == 1)
        {
            StudentHerkansingsLijst.DataSource = objHerkansing.VerkrijgBeschikbareHerkansingStudent(Userid).ToList();
            StudentHerkansingsLijst.DataBind();
        }
        if (rdbVeranderDisplay.SelectedIndex == 2)
        {
            StudentHerkansingsLijst.DataSource = objHerkansing.VerkrijgHistorieHerkansingenStudent(Userid).ToList();
            StudentHerkansingsLijst.DataBind();
        }
        #endregion

        #region voor de dropdownlist

        ////datavalue = herkansingID

        ddlSelecteerdHerkansing.DataSource = objHerkansing.DisplayHerkansingen(Userid);

        ddlSelecteerdHerkansing.DataValueField = "herkansingID";
        ddlSelecteerdHerkansing.DataTextField = "Vak";
        ddlSelecteerdHerkansing.DataTextFormatString = ""; //hier verder gaan..
        ddlSelecteerdHerkansing.DataBind();
        #endregion


    }

    protected int SelectRadioButtonValue()
    {
        if (rdbVeranderDisplay.SelectedIndex == 0)
            return rdbSelectedValue = 0;
        if (rdbVeranderDisplay.SelectedIndex == 1)
            return rdbSelectedValue = 1;
        if (rdbVeranderDisplay.SelectedIndex == 2)
            return rdbSelectedValue = 2;
        else
            return rdbSelectedValue = 0;
    }
}