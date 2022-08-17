using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class MemberRepo : IRepo<Member, int, bool>
    {

        HMS_APIEntities db = new HMS_APIEntities();

        public MemberRepo(HMS_APIEntities db)
        {
            this.db = db;
        }
        public bool Create(Member m)
        {
            db.Members.Add(m);
            var data=db.SaveChanges();

            if (data!= 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            //var m = db.Members.FirstOrDefault(db => db.Id == id);
            //db.Members.Remove(m);
            //return true;


            db.Members.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<Member> Get()
        {
            return db.Members.ToList();
        }

        public Member Get(int id)
        {
            return db.Members.FirstOrDefault(m => m.Id == id);
        }

        public   bool Update(Member obj)
        {
            var data = db.Members.FirstOrDefault(m => m.Id == obj.Id);
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
