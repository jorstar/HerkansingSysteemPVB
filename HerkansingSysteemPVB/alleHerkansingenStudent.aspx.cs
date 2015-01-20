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
    #region important stuffs
    public herkansingDBEntities objHerkansing = new herkansingDBEntities();
    public int rdbSelectedValue;
    public string Userid;
    public string sessHerkansingID = "";
    #endregion

    protected void Page_Load(object sender, EventArgs e)
    {
        Userid = (string)Session["User"];

        #region voor de radiobuttonlist
        SelectRadioButtonValue();
        rdbSelectedValue = rdbVeranderDisplay.SelectedIndex;

        if (rdbVeranderDisplay.SelectedIndex == 0)
        {
            dgvStudentenHerkansingsOverzicht.Visible = true;
            dgvStudentHerkansingOverzichtAlternatief.Visible = false;


            dgvStudentenHerkansingsOverzicht.DataSource = objHerkansing.VerkrijgBeschikbareHerkansingStudent(Userid).ToList();
            dgvStudentenHerkansingsOverzicht.DataBind();
        }

        if (rdbVeranderDisplay.SelectedIndex == 1)
        {
            dgvStudentenHerkansingsOverzicht.Visible = false;
            dgvStudentHerkansingOverzichtAlternatief.Visible = true;

            dgvStudentHerkansingOverzichtAlternatief.DataSource = objHerkansing.VerkrijgAlleHerkansingenStudent(Userid).ToList();
            dgvStudentHerkansingOverzichtAlternatief.DataBind();
        }

        if (rdbVeranderDisplay.SelectedIndex == 2)
        {
            dgvStudentenHerkansingsOverzicht.Visible = false;
            dgvStudentHerkansingOverzichtAlternatief.Visible = true;

            dgvStudentHerkansingOverzichtAlternatief.DataSource = objHerkansing.VerkrijgHistorieHerkansingenStudent(Userid).ToList();
            dgvStudentHerkansingOverzichtAlternatief.DataBind();
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
            e.Row.ToolTip = "selecteer een toets.";
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
                row.ToolTip = "selecteer een toets.";
        }
        ////selecter om aan te melden
        string selectedValueDataGrid = dgvStudentenHerkansingsOverzicht.SelectedRow.Cells[0].Text.ToString();
        Session["HerkansingID"] = selectedValueDataGrid;

        Response.Redirect("aanmeldenHerkansing.aspx");
    }
    protected void dgvStudentHerkansingOverzichtAlternatief_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dgvStudentHerkansingOverzichtAlternatief.PageIndex = e.NewPageIndex;
        dgvStudentHerkansingOverzichtAlternatief.DataBind();
    }
}