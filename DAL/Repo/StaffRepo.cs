using DAL.EF;
using DAL.Interfaces;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class StaffRepo : IRepo<Staff, int, bool>,IAuth<Staff>
    {
        HMS_APIEntities db = new HMS_APIEntities();

        public StaffRepo(HMS_APIEntities db)
        {
            this.db = db;
        }

        public Staff Authenticate(int id, string password)
        {
            return db.Staffs.FirstOrDefault(u => u.Id.Equals(id)
           && u.Password.Equals(password));
        }

        public bool Create(Staff obj)
        {
            db.Staffs.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            db.Staffs.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<Staff> Get()
        {
            {
                return db.Staffs.ToList();
            }
        }

        public Staff Get(int id)
        {
            {
                return db.Staffs.SingleOrDefault(s => s.Id == id);
            }
        }

        public bool Update(Staff obj)
        {
            var exst = db.Staffs.FirstOrDefault(s => s.Id == obj.Id);
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
