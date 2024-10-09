using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web10_Tuan5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                txtNoidung.Text = null;
                UpLoad(sender, e);
            }
        }
        protected void UpLoad(object sender, EventArgs e)
        {
            if (txtFile.HasFile)
            {
                string fileName = "App_Data/" + DateTime.Now.ToString("yyyyMMdd_hhmmss_tt_") + txtFile.FileName;
                string filePath = MapPath(fileName);
                txtFile.SaveAs(filePath);
            }
        }
    }
}