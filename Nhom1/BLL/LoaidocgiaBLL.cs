using DAL;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoaidocgiaBLL
    {
        LoaidocgiaDAL repos;
        public LoaidocgiaBLL()
        {
            repos = new LoaidocgiaDAL();
        }
        public List<LoaiDocGium> GetLoaiDocGia()
        {
            return repos.GetALL();
        }
    }
}
