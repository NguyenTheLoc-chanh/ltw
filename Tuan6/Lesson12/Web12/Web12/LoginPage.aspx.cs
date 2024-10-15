using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web12
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request.Form["txtNickName"];
            string color = Request.Form["txtColor"];

            if (name != null || color != null)
            {
                Member user = (Member)Session["Member"];
                user.sNickName = name;
                user.sColor = color;

                ArrayList listUser = (ArrayList)Application["Members"];
                listUser.Add(new Member(name, color));
                Response.Redirect("FrameSet.html");
            }
        }
    }
}