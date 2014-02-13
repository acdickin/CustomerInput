using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class donate : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Session["PersonKey"] != null)
        { 
        }
        else
        {
            Response.Redirect("default.aspx");
        }

    }
    protected void BtnDonate_Click(object sender, EventArgs e)
    {
       
        try
        {
            double.Parse(txtDonate.Text);
        }
        catch 
        {
            lblDError.Text = "You have not entered a number";
        }
      
        if (Session["PersonKey"] != null)
        {

            int pk = (int)Session["PersonKey"];
            Person p = new Person();
            Donation d = new Donation();
            d.Amount = Decimal.Parse(txtDonate.Text);
            
            ManagePerson mp = new ManagePerson(d, p);
            mp.WriteDonate(pk);
            Response.Redirect("Default2.aspx");
        }

      
    }
}