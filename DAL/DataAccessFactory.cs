using DAL.EF;
using DAL.Interfaces;
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

        public static IAuth<Admin> GetAdminAuthDataAccess()
        {
            return new AdminRepo(db);
        } 
        
        public static IAuth<Staff> GetStaffAuthDataAccess()
        {
            return new StaffRepo(db);
        }
        public static IAuth<Member> GetMemberAuthDataAccess()
        {
            return new MemberRepo(db);
        }
        public static IRepo<Token, string, Token> GetTokenDataAccess()
        {
            return new TokenRepo(db);
        }

        public static IRepo<In_Out_Notes, int, bool> GetIn_Out_NotesDataAccess()
        {
            return new In_Out_NotesRepo(db);
        }
        public static IRepo<CalGro, int, bool> GetCalGroDataAccess()
        {
            return new CalGroRepo(db);
        }

    }
}
