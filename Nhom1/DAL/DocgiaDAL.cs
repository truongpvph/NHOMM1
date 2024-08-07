using DTO.Context;
using DTO.DomainClass;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DocgiaDAL
    {
        MyContext context = new MyContext();
        public DocgiaDAL()
        {
            context = new MyContext();
        }
        public List<DocGium> GetAll()
        {
            return context.DocGia.ToList();
        }
        public bool Add_Obj(DocGium dg)
        {
            if (dg == null)
            {
                return false;
            }
            context.DocGia.Add(dg);
            context.SaveChanges();
            return true;
        }
        public bool Update_Obj(DocGium dg)
        {
            if (dg == null)
            {
                return false;
            }
            context.DocGia.Update(dg);
            context.SaveChanges();
            return true;
        }
    }
}
