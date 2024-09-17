using System;

namespace SimpleInterestNET_407
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal principal = decimal.Parse(txtPrincipal.Text);
                decimal rate = decimal.Parse(txtRate.Text);
                decimal time = decimal.Parse(txtTime.Text);

                decimal interest = (principal * rate * time) / 100;

                Session["Interest"] = interest;

                Response.Redirect("SIResult.aspx");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('Please enter valid numbers.');</script>");
            }
        }
    }
}