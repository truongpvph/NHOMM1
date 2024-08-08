using DTO.Context;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NXBRepos
    {
        MyContext context = new MyContext();
        public NXBRepos()
        {
            context  = new MyContext();
        }
        public List<NhaXuatBan> GetAll()
        {
            return context.NhaXuatBans.ToList();
        }
        public List<NhaXuatBan> GetXB(string ten)
        {
            return context.NhaXuatBans.Where(p => p.TenNhaXuatBan.Contains(ten)).ToList();
        }
        public bool AddXB(NhaXuatBan xb)
        {
            try
            {
                context.NhaXuatBans.Add(xb);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateXB(NhaXuatBan xb)
        {
            try
            {
                var updateItem = context.NhaXuatBans.Find(xb.MaNhaXuatBan);
                updateItem.MaNhaXuatBan = xb.MaNhaXuatBan;
                updateItem.TenNhaXuatBan = xb.TenNhaXuatBan;
                updateItem.DiaChi = xb.DiaChi;
                updateItem.Sdt = xb.Sdt;
                updateItem.Email = xb.Email;
                context.NhaXuatBans.Update(updateItem);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

}
