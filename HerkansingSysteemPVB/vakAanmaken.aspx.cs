﻿using System;
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
        if (txtVakNaam.Text != "" && txtVakBeschrijving.Text != "")
        {
            herkansingDBEntities entity = new herkansingDBEntities();

            entity.Vak.Add(new Vak { VakDescriptie = txtVakBeschrijving.Text, VakNaam = txtVakNaam.Text });

            entity.SaveChanges();
        }

        Response.Redirect("vakAanmaken.aspx");
    }
}