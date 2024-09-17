using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExceptionHandlingNET_407
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSquare_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(TextBox.Text);

                int result = number * number;

                lblResult.ForeColor = System.Drawing.Color.Blue;
                lblResult.Text = "Square of " + number + " is: " + result;
            }
            catch (FormatException ex)
            {
                lblResult.Text = "Error: Please enter a valid number.";
            }
            catch (Exception ex)
            {
                lblResult.Text = "An unexpected error occurred: " + ex.Message;
            }
        }
    }
}