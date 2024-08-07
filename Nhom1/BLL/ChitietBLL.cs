using DAL;
using DTO.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChitietBLL
    {
        ChitietDAL repos;
        public ChitietBLL()
        {
            repos = new ChitietDAL();
        }
        public List<ChiTietPhieuMuon> GetChiTietPhieuMuons()
        {
            return repos.GetAll();
        }
       
    }
}
