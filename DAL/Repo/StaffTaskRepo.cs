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
        public bool Create(StaffTask obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<StaffTask> Get()
        {
            throw new NotImplementedException();
        }

        public StaffTask Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(StaffTask obj)
        {
            throw new NotImplementedException();
        }
    }
}
