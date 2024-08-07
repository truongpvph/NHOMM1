using DAL;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BLL
{
    public class DocgiaBLL
    {
        DocgiaDAL repos;
        public DocgiaBLL()
        {
            repos = new DocgiaDAL();
        }
        public List<DocGium> GetDocGia()
        {
            return repos.GetAll();
        }
        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
        public string ThemDG(DocGium dg)
        {
            if(dg.NgaySinh > DateTime.Now)
            {
                return "Ngày sinh không được lớn hơn ngày hiện tại!";
            }
            if(dg.Sdt.Length != 10)
            {
                return "Số điện thoại phải là 10 số";
            }
            if(dg.Cmnd.Length != 12)
            {
                return "CCCD phải là 12 số";
            }
            if (!IsValidEmail(dg.Email))
            {
                return "Email không hợp lệ";
            }
            if (repos.GetAll().Any(d => d.Cmnd == dg.Cmnd))
            {
                return "CCCD đã tồn tại";
            }
            string[] validPrefixes = { "03", "08", "09" };
            if (!validPrefixes.Any(prefix => dg.Sdt.StartsWith(prefix)))
            {
                return "Số điện thoại phải bắt đầu bằng 03, 08 hoặc 09";
            }
            if (repos.GetAll().Any(d => d.Sdt == dg.Sdt))
            {
                return "Số điện thoại đã tồn tại";
            }
            if (repos.Add_Obj(dg))
            {
                return "Thêm thành công";
            }
            return "Thêm thất bại";
        }
        public string SuaDG(DocGium dg)
        {
            if (dg.NgaySinh > DateTime.Now)
            {
                return "Ngày sinh không được lớn hơn ngày hiện tại!";
            }
            if (dg.Sdt.Length != 10)
            {
                return "Số điện thoại phải là 10 số";
            }
            if (dg.Cmnd.Length != 12)
            {
                return "CCCD phải là 12 số";
            }
            if (!IsValidEmail(dg.Email))
            {
                return "Email không hợp lệ";
            }
            if (repos.GetAll().Any(d => d.Cmnd == dg.Cmnd && d.MaDocGia != dg.MaDocGia))
            {
                return "CCCD đã tồn tại";
            }
            string[] validPrefixes = { "03", "08", "09" };
            if (!validPrefixes.Any(prefix => dg.Sdt.StartsWith(prefix)))
            {
                return "Số điện thoại phải bắt đầu bằng 03, 08 hoặc 09";
            }
            if (repos.GetAll().Any(d => d.Sdt == dg.Sdt && d.MaDocGia != dg.MaDocGia))
            {
                return "Số điện thoại đã tồn tại";
            }
            if (repos.Update_Obj(dg))
            {
                return "Sửa thành công";
            }
            return "Sửa thất bại";
        }
    }
}
