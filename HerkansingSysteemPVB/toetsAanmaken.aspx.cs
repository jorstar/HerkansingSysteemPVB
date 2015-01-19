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

        if (Convert.ToString(Session["Role"]) != "D")
        {
            Response.Redirect("Home.aspx");
        }

        if (!Page.IsPostBack)
        {
            herkansingDBEntities entity = new herkansingDBEntities();

            ddlVakken.DataSource = entity.GetAllVaks();
            ddlVakken.DataTextField = "VakNaam";
            ddlVakken.DataValueField = "VakID";
            ddlVakken.DataBind(); 
        }

    }
    protected void btnBevestigen_Click(object sender, EventArgs e)
    {

        if (Page.IsValid)
        {

            herkansingDBEntities entity = new herkansingDBEntities();

            entity.Toets.Add(
                new Toets
                {
                    ToetsNaam = txtToetsTitel.Text,
                    ToetsDescriptie = txtToetsBeschrijving.Text,
                    Vak = Convert.ToInt32(ddlVakken.SelectedValue)
                }
                );

            entity.SaveChanges();

            Response.Redirect("toetsAanmaken.aspx");
        }

    }
}