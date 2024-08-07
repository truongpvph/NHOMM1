using DTO.Context;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChitietDAL
    {
        MyContext context = new MyContext();
        public ChitietDAL()
        {
            context = new MyContext();
        }
        public List<ChiTietPhieuMuon> GetAll()
        {
            return context.ChiTietPhieuMuons.ToList();
        }
        
    }
}
