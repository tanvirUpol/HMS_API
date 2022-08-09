using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class MealInfoRepo : IRepo<MealInfo, int, bool>
    {

        HMS_APIEntities db = new HMS_APIEntities();

        public MealInfoRepo(HMS_APIEntities db)
        {
            this.db = db;
        }
        public bool Create(MealInfo obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<MealInfo> Get()
        {
            throw new NotImplementedException();
        }

        public MealInfo Get(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(MealInfo obj)
        {
            throw new NotImplementedException();
        }
    }
}
