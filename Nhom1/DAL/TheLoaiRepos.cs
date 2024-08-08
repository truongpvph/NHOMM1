using DTO.Context;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TheLoaiRepos
    {
        MyContext context = new MyContext();
        public TheLoaiRepos()
        {
            context = new MyContext();
        }
        public List<TheLoai> GetAll()
        {
            return context.TheLoais.ToList();
        }
        public List<TheLoai> GetTL(string ten)
        {
            return context.TheLoais.Where(p => p.TenTheLoai.Contains(ten)).ToList();
        }
        public bool AddTL(TheLoai tl)
        {
            try
            {
                context.TheLoais.Add(tl);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateTL(TheLoai tl)
        {
            try
            {
                var updateItem = context.TheLoais.Find(tl.MaTheLoai);
                updateItem.TenTheLoai = tl.TenTheLoai;
                updateItem.MaTheLoai = tl.MaTheLoai;
                context.TheLoais.Update(updateItem);
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
