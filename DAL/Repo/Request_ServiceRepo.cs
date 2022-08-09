using DAL.Interfces;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class Request_ServiceRepo : IRepo<Request_Services, int ,bool>
    {
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
