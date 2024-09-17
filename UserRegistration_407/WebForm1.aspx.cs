using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserRegistration_407
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            Session["Name"] = txtName.Text;
            Session["Address"] = txtAddress.Text;
            Session["Email"] = txtEmail.Text;
            Session["Phone"] = txtPhone.Text;

            Response.Redirect("Display.aspx");
        }
    }
}