using DAL.EF;
using DAL.Interfces;
using DAL.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        static HMS_APIEntities db = new HMS_APIEntities();

        public static IRepo<Admin, int, bool> GetAdminDataAccess()
        {
            return new AdminRepo(db);
        }
    }
}
