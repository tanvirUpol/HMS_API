using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class StaffRepo : IRepo<Staff, int, bool>
    {
        HMS_APIEntities db = new HMS_APIEntities();

        public StaffRepo(HMS_APIEntities db)
        {
            this.db = db;
        }

        public bool Create(Staff obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Staff> Get()
        {
            throw new NotImplementedException();
        }

        public Staff Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Staff obj)
        {
            throw new NotImplementedException();
        }
    }
}
