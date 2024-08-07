using DTO.Context;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoaidocgiaDAL
    {
        MyContext context = new MyContext();
        public LoaidocgiaDAL()
        {
            context = new MyContext();
        }
        public List<LoaiDocGium> GetALL()
        {
            return context.LoaiDocGia.ToList();
        }
    }
}
