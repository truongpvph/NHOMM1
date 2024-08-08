using DAL;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TheLoaiSevice
    {
        TheLoaiRepos repos = new TheLoaiRepos();
        public TheLoaiSevice()
        {
            repos = new TheLoaiRepos();
        }
        public List<TheLoai> CNShow()
        {
            return repos.GetAll();
        }
        public List<TheLoai> CNTim(string ten)
        {
            return repos.GetTL(ten);
        }
        public string CNThem(TheLoai tl)
        {
            if (repos.AddTL(tl))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string CNSua(string ma, string ten)
        {
            TheLoai tl = new TheLoai()
            {
                MaTheLoai = ma,
                TenTheLoai = ten
            };
            if (repos.UpdateTL(tl))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
    }
}
