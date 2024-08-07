using DAL;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SachBLL
    {
        SachDAL repos;
        public SachBLL()
        {
            repos = new SachDAL();
        }
        public List<Sach> GetSaches()
        {
            return repos.GetAll();
        }
       
    }
}
