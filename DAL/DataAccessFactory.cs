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
        public static IRepo<Staff, int, bool> GetStaffDataAccess()
        {
            return new StaffRepo(db);
        }

        public static IRepo<StaffTask, int, bool> GetStaffTaskDataAccess()
        {
            return new StaffTaskRepo(db);
        }




        public static  IRepo<Member, int, bool> GetMemberDataAccess()
        {
            return new MemberRepo(db);
        }
        public static IRepo<MealInfo, int, bool> GetMealInfoDataAccess()
        {
            return new MealInfoRepo(db);
        }
        public static IRepo<Request_Services, int, bool> GetRequestServiceDataAccess()
        {
            return new RequestServiceRepo(db);
        }

        public static IRepo<HomeNotice, int, bool> GetHomeNoticeDataAccess()
        {
            return new HomeNoticeRepo(db);
        }

    }
}
