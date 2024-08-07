using DTO.Context;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieutraDAL
    {
        MyContext context = new MyContext();
        public PhieutraDAL()
        {
            context = new MyContext();
        }
        public List<Phieutra> GetAll()
        {
            return context.Phieutras.ToList();
        }
        
    }
}
