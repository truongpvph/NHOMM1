using DTO.Context;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaiDocGiaRepos
    {
        MyContext context = new MyContext();
        public LoaiDocGiaRepos() 
        {
            context = new MyContext();
        }
        public List<LoaiDocGium> GetAll()
        {
            return context.LoaiDocGia.ToList();
        }
        public List<LoaiDocGium> GetLDG(string ten)
        {
            return context.LoaiDocGia.Where(p => p.TenLoaiDocGia.Contains(ten)).ToList();
        }
        public bool AddLDG(LoaiDocGium ldg)
        {
            try
            {
                context.LoaiDocGia.Add(ldg);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateLDG(LoaiDocGium ldg)
        {
            try
            {
                var updateItem = context.LoaiDocGia.Find(ldg.MaLoaiDocGia);
                updateItem.MaLoaiDocGia = ldg.MaLoaiDocGia;
                updateItem.TenLoaiDocGia = ldg.TenLoaiDocGia;
                updateItem.SoSachMuonToiDa = ldg.SoSachMuonToiDa;
                updateItem.NgayMuonToiDa = ldg.NgayMuonToiDa;
                context.LoaiDocGia.Update(updateItem);
                context.SaveChanges();
                return true;
            }
            catch(Exception) 
            { 
                return false; 
            }
        }
        
    }
}
