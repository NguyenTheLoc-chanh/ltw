using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web11
{
    public partial class Xuly : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Nhanvien> nhanviens = Session["danhsach"] as List<Nhanvien>;
            string inputName = Request.Form["name"];
            string inputDate = Request.Form["date"];

            Nhanvien nv = new Nhanvien();
            nv.SName = inputName;
            nv.SDate = inputDate;

            if(nhanviens != null)
            {
                nhanviens.Add(nv);
                Session["danhsach"] = nhanviens;
            }
            table.InnerHtml = GenerateTable();
        }

        protected string GenerateTable()
        {
            List<Nhanvien> nhanviens = Session["danhsach"] as List<Nhanvien>;
            if (nhanviens == null || nhanviens.Count == 0)
            {
                return "<tr><td colspan='2'>Không có nhân viên nào.</td></tr>";
            }

            string tableHtml = "<table><tr><td>Họ và tên<td/><td>Ngày sinh<td/><tr/>";

            foreach (var nv in nhanviens)
            {
                tableHtml += $"<tr><td>{nv.SName}</td><td>{nv.SDate}</td></tr>";
            }
            tableHtml += "<table/>";
            return tableHtml;
        }
    }
}