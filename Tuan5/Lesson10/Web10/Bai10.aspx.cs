using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web10
{
    public partial class Bai10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                txtNoidung.Text = null;
                Upload(sender, e);
            }
        }
        protected void Upload(object sender, EventArgs e)
        {
            if (txtFile.HasFile)
            {
                string fileName = "~/App_Data/" + DateTime.Now.ToString("yyyyMMdd_hhmmss_tt_") + txtFile.FileName;
                string filePath = MapPath(fileName);
                txtFile.SaveAs(filePath);
            }
        }
        /*if (!IsPostBack)
        {
            // Nếu là lần đầu tiên load trang, hiển thị lại dữ liệu cũ (nếu có)
            if (Request.Form["txtNoidung"] != null)
            {
                txt.InnerText = Request.Form["txtNoidung"];
            }
        }*/

    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        /*// Lấy nội dung từ textarea
        string noidung = txtNoidung.InnerText;

        // Lưu nội dung vào query string để hiển thị lại khi reload trang
        Response.Redirect("Bai10.aspx?noidung=" + Server.UrlEncode(noidung));

        // Lưu file lên server
        if (FileUpload1.HasFile)
        {
            string fileName = Path.GetFileName(FileUpload1.FileName);
            string filePath = Server.MapPath(@"F:\ThietKe_Web\LearningWebClass\Tuan5\Lesson10\Web10\App_Data\" + fileName);
            FileUpload1.SaveAs(filePath);
        }*/
        /*if (Request.Form["txtNoidung"] != null && Request.Files["txtFile"] != null)
        {
            //Lấy file từ form
            HttpPostedFile uploadFile = Request.Files["txtFile"];
            Response.Write("Đây là nội dung được tải lên:" + Request.Form["txtNoidung"]);

            // Lấy tên file
            string fileName = Path.GetFileName(uploadFile.FileName);
            string filePath = Path.Combine(Server.MapPath("~/App_Data/"), fileName);

            uploadFile.SaveAs(filePath);

            Response.Write("File đã lưu:" + filePath);
            Response.End();
        }
        else
        {
            Response.Write("Vui lòng chọn file!");
            Response.End();
        }*/

    } }
        /*public void OnClick()
        {
            if (Request.Form["txtNoidung"] != null && Request.Files["txtFile"] != null)
            {
                //Lấy file từ form
                HttpPostedFile uploadFile = Request.Files["txtFile"];
                Response.Write("Đây là nội dung được tải lên:" + Request.Form["txtNoidung"]);

                // Lấy tên file
                string fileName = Path.GetFileName(uploadFile.FileName);
                string filePath = Path.Combine(Server.MapPath("~/App_Data/"), fileName);

                uploadFile.SaveAs(filePath);

                Response.Write("File đã lưu:" + filePath);
                Response.End();
            }
            else
            {
                Response.Write("Vui lòng chọn file!");
                Response.End();
            }
        }*/
}