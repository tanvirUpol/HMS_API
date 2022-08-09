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
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Request_Services> Get()
        {
            throw new NotImplementedException();
        }

        public Request_Services Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Request_Services obj)
        {
            throw new NotImplementedException();
        }
    }
}
