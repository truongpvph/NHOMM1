using DTO.Context;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SachDAL
    {
        MyContext context = new MyContext();
        public SachDAL()
        {
            context = new MyContext();
        }
        public List<Sach> GetAll()
        {
            return context.Saches.ToList();
        }
        

        
    }
}
