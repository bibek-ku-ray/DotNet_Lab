using System;

namespace SimpleInterestNET_407
{
    public partial class SIResult : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Interest"] != null)
            {
                LabelResult.Text = Session["Interest"].ToString();
            }
            else
            {
                LabelResult.Text = "No data available.";
            }
        }
    }
}