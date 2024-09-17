using System;
using System.Web.UI;

namespace DelegateAndEvent_407
{
    public delegate void ButtonClickedEventHandler(object sender, EventArgs e);

    public partial class WebForm1 : System.Web.UI.Page
    {
        public event ButtonClickedEventHandler ButtonClickedEvent;

        protected void Page_Load(object sender, EventArgs e)
        {
            ButtonClickedEvent += OnButtonClicked;
        }

        protected void ButtonClick_Click(object sender, EventArgs e)
        {
            ButtonClickedEvent?.Invoke(this, EventArgs.Empty);
        }

        protected void OnButtonClicked(object sender, EventArgs e)
        {
            Response.Write("<script>alert('Button has been clicked!');</script>");
        }
    }
}
