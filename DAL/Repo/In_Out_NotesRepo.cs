using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class In_Out_NotesRepo : IRepo<In_Out_Notes, int, bool>
    {
        HMS_APIEntities db = new HMS_APIEntities();

        public In_Out_NotesRepo(HMS_APIEntities db)
        {
            this.db = db;
        }

        public bool Create(In_Out_Notes obj)
        {
            db.In_Out_Notes.Add(obj);
            var res = db.SaveChanges();
            if (res != 0)
            {
                return true;
            }
            return false;
        }

        public bool Delete(int id)
        {
            db.In_Out_Notes.Remove(Get(id));
            db.SaveChanges();
            return true;
        }

        public List<In_Out_Notes> Get()
        {
            {
                return db.In_Out_Notes.ToList();
            }
        }

        public In_Out_Notes Get(int id)
        {
            {
                return db.In_Out_Notes.SingleOrDefault(s => s.Id == id);
            }
        }

        public bool Update(In_Out_Notes obj)
        {
            var exst = db.In_Out_Notes.FirstOrDefault(s => s.Id == obj.Id);
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
