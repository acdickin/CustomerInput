using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    { 
   
    }
    protected void btnSubmit_Click1(object sender, EventArgs e)
    {
        Person p = new Person();
        Donation d = new Donation();
        p.LastName = txtLast.Text;
        p.Firstname = txtFirst.Text;
        p.Email = txtEmail.Text;
        p.Password = txtComfirm.Text;

      
        

        ManagePerson mp = new ManagePerson(d, p);
        mp.WritePerson();
        
        lblError.Text = "Thank you for regestering";
    }
}