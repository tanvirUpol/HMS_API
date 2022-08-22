using DAL.EF;
using DAL.Interfces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class TokenRepo : IRepo<Token, string, Token>
    {
        HMS_APIEntities db;
        public TokenRepo(HMS_APIEntities db)
        {
            this.db = db;
        }
        public Token Create(Token obj)
        {
            db.Tokens.Add(obj);
            db.SaveChanges();
            return obj;
        }
        public bool Delete(string id)
        {
            throw new NotImplementedException();
        }

        public List<Token> Get()
        {
            throw new NotImplementedException();
        }

        public Token Get(string token)
        {
            return db.Tokens.FirstOrDefault(t => t.Token1.Equals(token));
        }



        public bool Update(Token obj)
        {
            var exst = db.Tokens.FirstOrDefault(x => x.Token1.Equals(obj.Token1));
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
