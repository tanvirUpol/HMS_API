using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class RequestServiceRepo : IRepo<Request_Services, int, bool>
    {
        HMS_APIEntities db = new HMS_APIEntities();

        public RequestServiceRepo(HMS_APIEntities db)
        {
            this.db = db;
        }

        public bool Create(Request_Services obj)
        {
            db.Request_Services.Add(obj);
            var data = db.SaveChanges();

            if (data != 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            
            db.Request_Services.Remove(Get(id));
            db.SaveChanges();
            return true;

        }

        public List<Request_Services> Get()
        {
            return db.Request_Services.ToList(); ;
        }

        public Request_Services Get(int id)
        {
            return db.Request_Services.FirstOrDefault(m => m.Id == id);
        }

        public bool Update(Request_Services obj)
        {
            var data = db.Request_Services.FirstOrDefault(m => m.Id == obj.Id);
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
