using DAL;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NXBSevice
    {
        NXBRepos repos = new NXBRepos();
        public NXBSevice()
        {
            repos = new NXBRepos();
        }
        public List<NhaXuatBan> CNShow()
        {
            return repos.GetAll();
        }
        public List<NhaXuatBan> CNTim(string ten)
        {
            return repos.GetXB(ten);
        }
        public string CNThem(NhaXuatBan xb)
        {
            if (repos.AddXB(xb))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string CNSua(string ma, string ten, string dchi, string sdt, string email)
        {
            NhaXuatBan xb = new NhaXuatBan()
            {
                MaNhaXuatBan = ma,
                TenNhaXuatBan = ten,
                DiaChi = dchi,
                Sdt = sdt,
                Email = email
            };
            if (repos.UpdateXB(xb))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
        public bool CheckSDT(string sdt)
        {
            if (sdt.Length == 10 || sdt.Trim().Length == 0) return false;
            else return true;
        }
    }
}
