using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;


public partial class _Default : System.Web.UI.Page
{
    public int Userid = 0015180; // verwijderen als de Session dingen zijn geregeld\\
    public string sessHerkansingID = "";

    #region important stuffs
    public herkansingDBEntities objHerkansing = new herkansingDBEntities();
    public int rdbSelectedValue;
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        ////Session["userID"] = Userid;
        ////Sesssion[""] //moet een waarde krijgen voor de geselecteerde herkansing

        #region selecteren van row in de datagrid

        if (!this.IsPostBack)
        {

        }

        #endregion

        #region voor de radiobuttonlist
        SelectRadioButtonValue();
        rdbSelectedValue = rdbVeranderDisplay.SelectedIndex;

        if (rdbVeranderDisplay.SelectedIndex == 0)
        {
            dgvStudentenHerkansingsOverzicht.DataSource = objHerkansing.VerkrijgBeschikbareHerkansingStudent(Userid).ToList();
            dgvStudentenHerkansingsOverzicht.DataBind();
        }

        if (rdbVeranderDisplay.SelectedIndex == 1)
        {
            dgvStudentenHerkansingsOverzicht.DataSource = objHerkansing.VerkrijgAlleHerkansingenStudent(Userid).ToList();
            dgvStudentenHerkansingsOverzicht.DataBind();
        }

        if (rdbVeranderDisplay.SelectedIndex == 2)
        {
            dgvStudentenHerkansingsOverzicht.DataSource = objHerkansing.VerkrijgHistorieHerkansingenStudent(Userid).ToList();
            dgvStudentenHerkansingsOverzicht.DataBind();
        }
        #endregion

        #region voor de dropdownlist
        if (!IsPostBack)
        {
            ddlSelecteerdHerkansing.DataSource = objHerkansing.DisplayHerkansingen(Userid).ToList();
            ddlSelecteerdHerkansing.DataTextField = "DropdownlistInfo";
            ddlSelecteerdHerkansing.DataValueField = "HerkansingID";
            ddlSelecteerdHerkansing.DataBind();
        }
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

    protected void btnAanmelden_Click(object sender, EventArgs e)
    {
        ////sessions versturen OF aanmelden voor een herkansing
        sessHerkansingID = ddlSelecteerdHerkansing.SelectedValue;
        Session["HerkansingID"] = sessHerkansingID;

        Response.Redirect("aanmeldenHerkansing.aspx");
    }
    protected void dgvStudentenHerkansingsOverzicht_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dgvStudentenHerkansingsOverzicht.PageIndex = e.NewPageIndex;
        dgvStudentenHerkansingsOverzicht.DataBind();

    }
    protected void dgvStudentenHerkansingsOverzicht_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(dgvStudentenHerkansingsOverzicht, "Select$" + e.Row.RowIndex);
            e.Row.ToolTip = "selecteren om een toets te kiezen";
        }
    }
    protected void dgvStudentenHerkansingsOverzicht_SelectedIndexChanged(object sender, EventArgs e)
    {
        foreach (GridViewRow row in dgvStudentenHerkansingsOverzicht.Rows)
        {
            if (row.RowIndex == dgvStudentenHerkansingsOverzicht.SelectedIndex)
            {
                row.BackColor = ColorTranslator.FromHtml("#B7C6D6");
                row.ToolTip = string.Empty;
            }
            else
                row.ToolTip = "selecteren om een toets te kiezen";
        }
    }
}