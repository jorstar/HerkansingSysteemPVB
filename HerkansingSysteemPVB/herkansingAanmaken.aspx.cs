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

        if (!Page.IsPostBack)
        {
            herkansingDBEntities entiry = new herkansingDBEntities();

            ddlToetsen.DataSource = entiry.GetAllToets();
            ddlToetsen.DataValueField = "toetsID";
            ddlToetsen.DataTextField = "toetsNaam";
            ddlToetsen.DataBind();

            ddlSureillance.DataSource = entiry.GetAllSurveillance();
            ddlSureillance.DataTextField = "DocentInfo";
            ddlSureillance.DataValueField = "DocentID";
            ddlSureillance.DataBind();

            rblKlasOfOpleiding.SelectedIndex = 0;

        }

        if (rblKlasOfOpleiding.SelectedIndex == 0)
        {
            herkansingDBEntities entity = new herkansingDBEntities();
            ddlKlasOfOpleidingSelecteren.DataSource = entity.GetAllklassen();
            ddlKlasOfOpleidingSelecteren.DataBind();

        }
        else
        {
            herkansingDBEntities entity = new herkansingDBEntities();
            ddlKlasOfOpleidingSelecteren.DataSource = entity.GetAllopleidingen();
            ddlKlasOfOpleidingSelecteren.DataBind();
        }


    }
}