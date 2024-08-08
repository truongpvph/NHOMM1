using DAL;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaiDocGiaSevice
    {
        LoaiDocGiaRepos repos = new LoaiDocGiaRepos();
        public LoaiDocGiaSevice()
        {
            repos = new LoaiDocGiaRepos();
        }
        public List<LoaiDocGium> CNShow()
        {
            return repos.GetAll();
        }
        public List<LoaiDocGium> CNTim(string ten)
        {
            return repos.GetLDG(ten);
        }
        public string CNThem(LoaiDocGium ldg)
        {
            if (repos.AddLDG(ldg))
            {
                return "Thêm thành công";
            }
            else return "Thêm thất bại";
        }
        public string CNSua(string ma, string ten, int sach, int ngay)
        {
            LoaiDocGium ldg = new LoaiDocGium()
            {
                MaLoaiDocGia = ma,
                TenLoaiDocGia = ten,
                SoSachMuonToiDa = sach,
                NgayMuonToiDa = ngay
            };
            if (repos.UpdateLDG(ldg))
            {
                return "Sửa thành công";
            }
            else return "Sửa thất bại";
        }
    }
}
