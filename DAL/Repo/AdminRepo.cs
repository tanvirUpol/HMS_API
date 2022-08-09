using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL.Repo
{
    public class AdminRepo : IRepo<Admin, int, bool>
    {
        HMS_APIEntities db = new HMS_APIEntities();

        public AdminRepo(HMS_APIEntities db)
        {
            this.db = db;
        }
        //this is create
        public bool Create(Admin obj)
        {
            db.Admins.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            db.Admins.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<Admin> Get()
        {
            return db.Admins.ToList();
        }

        public Admin Get(int id)
        {
            return db.Admins.SingleOrDefault(s => s.Id == id);
        }

        public bool Update(Admin obj)
        {
            var exst = db.Admins.FirstOrDefault(s => s.Id == obj.Id);
            if(exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                db.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
