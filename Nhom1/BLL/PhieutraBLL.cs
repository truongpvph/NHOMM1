using DAL;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieutraBLL
    {
        PhieutraDAL repos;
        public PhieutraBLL()
        {
            repos = new PhieutraDAL();
        }
        public List<Phieutra> GetPhieutras()
        {
            return repos.GetAll();
        }
        
    }
}
