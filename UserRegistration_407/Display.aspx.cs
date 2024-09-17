using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UserRegistration_407
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Session["Name"] as string;
            string address = Session["Address"] as string;
            string email = Session["Email"] as string;
            string phone = Session["Phone"] as string;

            lblName.Text = "Name: " + (name ?? "N/A");
            lblAddress.Text = "Address: " + (address ?? "N/A");
            lblEmail.Text = "Email: " + (email ?? "N/A");
            lblPhone.Text = "Phone: " + (phone ?? "N/A");
        }
    }
}