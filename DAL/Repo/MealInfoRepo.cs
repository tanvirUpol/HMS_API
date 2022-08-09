using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class MealInfoRepo : IRepo<MealInfo, int, bool>
    {

        HMS_APIEntities db = new HMS_APIEntities();

        public MealInfoRepo(HMS_APIEntities db)
        {
            this.db = db;
        }
        public bool Create(MealInfo obj)
        {
            db.MealInfos.Add(obj);
            var data = db.SaveChanges();

            if (data != 0)
            {
                return true;
            }
            return false;

        }

        public bool Delete(int id)
        {
            var m = db.MealInfos.FirstOrDefault(db => db.Id == id);
            db.MealInfos.Remove(m);
            return true;
        }

        public List<MealInfo> Get()
        {
            return db.MealInfos.ToList();
        }

        public MealInfo Get(int id)
        {
            return db.MealInfos.FirstOrDefault(m => m.Id == id);
        }

        public bool Update(MealInfo obj)
        {
            var data = db.MealInfos.FirstOrDefault(m => m.Id == obj.Id);
            if (data != null)
            {
                db.Entry(data).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
