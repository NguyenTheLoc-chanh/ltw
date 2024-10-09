using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson9_Tuan5
{
    public partial class XuLy2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string inputName = Request.QueryString.Get("name");
            string inputHang = Request.QueryString.Get("hang");
            string inputdate = Request.QueryString.Get("date");
            string inputPrice = Request.QueryString.Get("price");

            string resXML =
               "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
               "<table>" +
                   "<tr>" +
                       "<td>" + System.Security.SecurityElement.Escape(inputName) + "</td>" +
                       "<td>" + System.Security.SecurityElement.Escape(inputHang) + "</td>" +
                       "<td>" + System.Security.SecurityElement.Escape(inputdate) + "</td>" +
                       "<td>" + System.Security.SecurityElement.Escape(inputPrice) + "</td>" +
                   "</tr>" +
               "</table>";
            Response.ContentType = "text/xml"; // Thiết lập loại nội dung
            Response.ContentEncoding = System.Text.Encoding.UTF8; // Thiết Lập mã hóa 
            Response.Write(resXML);
            Response.End();
        }
    }
}