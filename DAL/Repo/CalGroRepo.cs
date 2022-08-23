using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class CalGroRepo : IRepo<CalGro, int, bool>
    {
        HMS_APIEntities db = new HMS_APIEntities();

        public CalGroRepo(HMS_APIEntities db)
        {
            this.db = db;
        }


        public bool Create(CalGro obj)
        {
            db.CalGros.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            db.CalGros.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<CalGro> Get()
        {
            return db.CalGros.ToList();
        }

        public CalGro Get(int id)
        {
            return db.CalGros.SingleOrDefault(s => s.Id == id);
        }

        public bool Update(CalGro obj)
        {
            var exst = db.CalGros.FirstOrDefault(s => s.Id == obj.Id);
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
