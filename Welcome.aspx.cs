using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
public partial class Welcome : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["PersonKey"] != null)
        {
            
            int pk = (int)Session["PersonKey"];

            ManageVeh mv = new ManageVeh();
            DataTable t = mv.GetDonation(pk);
            foreach (DataRow dr in t.Rows)
            {
             
            }
           
            gvVeh.DataSource = t;
            gvVeh.DataBind();
            
            DataTable j = mv.GetName(pk);
        

            foreach (DataRow dj in j.Rows)
            {
              lblWelcome.Text = "Welcome " + dj["PersonFirstName"].ToString() + " " + dj["PersonLastName"].ToString();  
            }
           
        }
        else
        {
            Response.Redirect("default.aspx");
        }
    }
    protected void gvVeh_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void BtnDonate_Click(object sender, EventArgs e)
    {
        Response.Redirect("Donate.aspx");
    }
}