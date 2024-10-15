using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web12
{
    public partial class MessageList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack != null)
            {
                showMessList();

            }
        }

        private void showMessList()
        {

            ArrayList listND = (ArrayList)Application["MessSend"];
            Response.Write("<h2>Message List</h2>");
            if (listND != null)
            {
                Member user = (Member)Session["Member"];
                foreach (MessSendInfo messenger in listND)
                {
                    if (user.sNickName == messenger.snickName)
                    {
                        Response.Write("<p style='color:" + messenger.scolor + ";text-align: right;'><b>" + messenger.snickName + ":&nbsp;"
                            + messenger.smessage + "&nbsp;(" + messenger.stimeStamp + ")</b></p>");
                    }
                    else
                    {
                        Response.Write("<p style='color:" + messenger.scolor + "'>" + messenger.snickName + ":&nbsp;"
                            + messenger.smessage + "&nbsp;(" + messenger.stimeStamp + ")</p>");
                    }
                }
            }
        }
        }
}