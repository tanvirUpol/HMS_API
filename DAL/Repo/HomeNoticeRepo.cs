using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class HomeNoticeRepo : IRepo<HomeNotice, int, bool>
    {
        HMS_APIEntities db = new HMS_APIEntities();

        public HomeNoticeRepo(HMS_APIEntities db)
        {
            this.db = db;
        }
        public bool Create(HomeNotice obj)
        {
            db.HomeNotices.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            db.HomeNotices.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<HomeNotice> Get()
        {
            return db.HomeNotices.ToList();
        }

        public HomeNotice Get(int id)
        {
            return db.HomeNotices.SingleOrDefault(s => s.Id == id);
        }

        public bool Update(HomeNotice obj)
        {
            var exst = db.HomeNotices.FirstOrDefault(s => s.Id == obj.Id);
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
