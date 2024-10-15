using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web12
{
    public partial class Members : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Page.IsPostBack != null)
            {
                showMerbers();
            }
        }

        private void showMerbers()
        {
            Response.Write("<h2>Members</h2>");
            ArrayList listUser = (ArrayList)Application["Members"];
            Member us = (Member)Session["Member"];

            if(listUser != null)
            {
                foreach (Member u in listUser)
                {
                    if (u.sNickName == us.sNickName && u.sColor == us.sColor)
                    {
                        Response.Write("<h2 style='color:" + u.sColor + "'><b><u>" + u.sNickName + "</u></b></h2>");
                    }
                    else
                    {
                        Response.Write("<p style='color:" + u.sColor + "'>" + u.sNickName + "</p>");
                    }
                }
            }
        }
    }
}