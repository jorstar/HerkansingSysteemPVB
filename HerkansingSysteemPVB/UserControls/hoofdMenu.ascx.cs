using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserControlls_Menu : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Convert.ToString(Session["Role"]) == "B")
        {
            MenuItem AanmakenDocent = Hoofdmenu.FindItem("AanmakenDocent");
            Hoofdmenu.Items.Remove(AanmakenDocent);
            MenuItem HerkansingOverzichtStudent = Hoofdmenu.FindItem("HerkansingOverzichtStudent");
            Hoofdmenu.Items.Remove(HerkansingOverzichtStudent);
            MenuItem AanmeldenHerkansing = Hoofdmenu.FindItem("AanmeldenHerkansing");
            Hoofdmenu.Items.Remove(AanmeldenHerkansing);

        }
        else if(Convert.ToString(Session["Role"]) == "D")
        {
            MenuItem AanmakenBeheer = Hoofdmenu.FindItem("AanmakenBeheer");
            Hoofdmenu.Items.Remove(AanmakenBeheer);
            MenuItem AanmeldenHerkansing = Hoofdmenu.FindItem("AanmeldenHerkansing");
            Hoofdmenu.Items.Remove(AanmeldenHerkansing);
        }
        else if (Convert.ToString(Session["Role"]) == "S")
        {
            MenuItem AanmakenDocent = Hoofdmenu.FindItem("AanmakenDocent");
            Hoofdmenu.Items.Remove(AanmakenDocent);
            MenuItem AanmakenBeheer = Hoofdmenu.FindItem("AanmakenBeheer");
            Hoofdmenu.Items.Remove(AanmakenBeheer);
            MenuItem HerkansingOverzichtDocent = Hoofdmenu.FindItem("HerkansingOverzichtDocent");
            Hoofdmenu.Items.Remove(HerkansingOverzichtDocent);
        }
        else
        {
            MenuItem AanmakenDocent = Hoofdmenu.FindItem("AanmakenDocent");
            Hoofdmenu.Items.Remove(AanmakenDocent);
            MenuItem AanmakenBeheer = Hoofdmenu.FindItem("AanmakenBeheer");
            Hoofdmenu.Items.Remove(AanmakenBeheer);
            MenuItem AanmeldenHerkansing = Hoofdmenu.FindItem("AanmeldenHerkansing");
            Hoofdmenu.Items.Remove(AanmeldenHerkansing);
            MenuItem HerkansingOverzichtDocent = Hoofdmenu.FindItem("HerkansingOverzichtDocent");
            Hoofdmenu.Items.Remove(HerkansingOverzichtDocent);
            MenuItem Home = Hoofdmenu.FindItem("Home");
            Hoofdmenu.Items.Remove(Home);
            MenuItem WachtwoordWijzigen = Hoofdmenu.FindItem("WachtwoordWijzigen");
            Hoofdmenu.Items.Remove(WachtwoordWijzigen);
            MenuItem Uitloggen = Hoofdmenu.FindItem("Uitloggen");
            Hoofdmenu.Items.Remove(Uitloggen);
        }
    }
}