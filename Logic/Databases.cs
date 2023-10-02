using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Databases
    {
        private BaseDao dao;
        public Databases()
        {
            dao = new BaseDao();
        }

        public List<Databases_Model> Get_All_Databases()
        {
            return dao.GetDatabases();
        }
    }
}
