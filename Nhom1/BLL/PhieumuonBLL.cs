using DAL;
using DTO.Context;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieumuonBLL
    {
        PhieumuonDAL repos;
        public PhieumuonBLL()
        {
            repos = new PhieumuonDAL();
        }
        public List<PhieuMuon> GetPhieuMuons()
        {
            return repos.GetAll();
        }
        
    }
}
