using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web12
{
    public partial class SendMsg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack != null)
            {
                showMess();
            }
        }
        private void showMess()
        {
            string mess = Request.Form["txtMessage"];
            if (mess != null)
            {
                ArrayList listND = (ArrayList)Application["MessSend"];
                Member user = (Member)Session["Member"];
                string time = DateTime.Now.ToShortTimeString();
                listND.Add(new MessSendInfo(user.sNickName, user.sColor, mess, time));
                Response.Redirect("PostMsg.html");
            }
        }
        }
}