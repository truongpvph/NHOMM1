using DTO.Context;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieumuonDAL
    {
        MyContext context = new MyContext();
        public PhieumuonDAL()
        {
            context = new MyContext();
        }
        public List<PhieuMuon> GetAll()
        {
            return context.PhieuMuons.ToList();
        }
       
    }
}
