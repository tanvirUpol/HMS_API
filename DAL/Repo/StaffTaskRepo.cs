using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class StaffTaskRepo : IRepo<StaffTask, int, bool>
    {
        HMS_APIEntities db = new HMS_APIEntities();

        public StaffTaskRepo(HMS_APIEntities db)
        {
            this.db = db;
        }

        public bool Create(StaffTask obj)
        {
            db.StaffTasks.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            db.StaffTasks.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<StaffTask> Get()
        {
            return db.StaffTasks.ToList();
        }

        public StaffTask Get(int id)
        {
            return db.StaffTasks.SingleOrDefault(s => s.Id == id);
        }

        public bool Update(StaffTask obj)
        {
            var exst = db.StaffTasks.FirstOrDefault(s => s.Id == obj.Id);
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
