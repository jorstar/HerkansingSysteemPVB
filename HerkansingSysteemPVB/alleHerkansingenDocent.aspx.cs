﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    public herkansingDBEntities objHerkansing = new herkansingDBEntities();
    public int rdbSelectedValue;
    public string DocentID = "WGS01";
    public string HerkansingsIDString = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        ////Session["userID"] = Userid;
        ////Sesssion[""] //moet een waarde krijgen voor de geselecteerde herkansing
        #region voor de radiobuttonlist
        SelectRadioButtonValue();
        rdbSelectedValue = rdbVeranderDisplay.SelectedIndex;

        if (rdbVeranderDisplay.SelectedIndex == 0)
        {
            dgvDocentenHerkansingOverzicht.DataSource = objHerkansing.VerkrijgBeschikbareHerkansingDocent().ToList();
            dgvDocentenHerkansingOverzicht.DataBind();
        }
        if (rdbVeranderDisplay.SelectedIndex == 1)
        {
            dgvDocentenHerkansingOverzicht.DataSource = objHerkansing.VerkrijgAlleHerkansingenDocent().ToList();
            dgvDocentenHerkansingOverzicht.DataBind();
        }
        if (rdbVeranderDisplay.SelectedIndex == 2)
        {
            dgvDocentenHerkansingOverzicht.DataSource = objHerkansing.VerkrijgHistorieHerkansingenDocent().ToList();
            dgvDocentenHerkansingOverzicht.DataBind();
        }
        if (rdbVeranderDisplay.SelectedIndex == 3)
        {
            dgvDocentenHerkansingOverzicht.DataSource = objHerkansing.verkrijgHerkansingenGemaaktDoorDocent(DocentID).ToList();
            dgvDocentenHerkansingOverzicht.DataBind();
        }
        #endregion

        #region voor de dropdownlist
        if (!IsPostBack)
        {
            ddlSelecteerdHerkansing.DataSource = objHerkansing.DisplayHerkansingenDocent();
            ddlSelecteerdHerkansing.DataValueField = "herkansingID";

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
        if (rdbVeranderDisplay.SelectedIndex == 3)
            return rdbSelectedValue = 3;
        else
            return rdbSelectedValue = 0;
    }
    protected void ddlSelecteerdHerkansing_SelectedIndexChanged(object sender, EventArgs e)
    {
        HerkansingsIDString = ddlSelecteerdHerkansing.SelectedValue;
    }
    protected void btnTonen_Click(object sender, EventArgs e)
    {
        HerkansingsIDString = ddlSelecteerdHerkansing.SelectedValue;

        dgvDocentenHerkansingOverzicht.DataSource = objHerkansing.VerkrijgAlleStudentenVanEenHerkansing(Convert.ToInt32(HerkansingsIDString));
        dgvDocentenHerkansingOverzicht.DataBind();
    }
    protected void dgvDocentenHerkansingOverzicht_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        dgvDocentenHerkansingOverzicht.PageIndex = e.NewPageIndex;
        dgvDocentenHerkansingOverzicht.DataBind();
    }
    protected void dgvDocentenHerkansingOverzicht_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(dgvDocentenHerkansingOverzicht, "Select$" + e.Row.RowIndex);
            e.Row.ToolTip = "selecteer een toets kiezen";
        }
    }
    protected void dgvDocentenHerkansingOverzicht_SelectedIndexChanged(object sender, EventArgs e)
    {
        foreach (GridViewRow row in dgvDocentenHerkansingOverzicht.Rows)
        {
            if (row.RowIndex == dgvDocentenHerkansingOverzicht.SelectedIndex)
            {
                row.BackColor = ColorTranslator.FromHtml("#B7C6D6");
                row.ToolTip = string.Empty;
            }
            else
                row.ToolTip = "selecteer een toets.";
        }
    }
}