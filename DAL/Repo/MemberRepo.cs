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
        public bool Create(Member obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Member> Get()
        {
            throw new NotImplementedException();
        }

        public Member Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Member obj)
        {
            throw new NotImplementedException();
        }
    }
}
