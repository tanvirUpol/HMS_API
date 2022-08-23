using BLL.BOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService
    {
       public static TokenModel Authenticate(int id, string pass)
        {
            var admin = DataAccessFactory.GetAdminAuthDataAccess().Authenticate(id, pass);
            var staff = DataAccessFactory.GetStaffAuthDataAccess().Authenticate(id, pass);
            dynamic user = null;
            if(staff != null)
            {
                user = staff;
            }
            if (admin != null)
            {
                user = admin;
            }


            TokenModel t = null;
            if (user != null)
            {
                var key = GenToken();
                Token token = new Token();
                token.Token1 = key;
                token.UserId = user.Id;
                token.CreatedAt = DateTime.Now;
                token.Type = user.Type;
                var created_token = DataAccessFactory.GetTokenDataAccess().Create(token);
                t = new TokenModel()
                {
                    Id = created_token.Id,
                    Token1 = created_token.Token1,
                    CreatedAt = created_token.CreatedAt,
                    UserId = created_token.UserId,
                    ExpiredAt = created_token.ExpiredAt,
                    Type = created_token.Type,
                };


            }
            return t;
        }

        public static string GenToken()
        {
            Random res = new Random();

            // String of alphabets 
            String str = "abcdefghijklmnopqrstuvwxyz";
            int size = 40;

            // Initializing the empty string
            String ran = "";

            for (int i = 0; i < size; i++)
            {

                // Selecting a index randomly
                int x = res.Next(26);

                // Appending the character at the 
                // index to the random string.
                ran = ran + str[x];
            }
            return ran;
        }


        public static int TokenValidity(string token)
        {
            var tk = DataAccessFactory.GetTokenDataAccess().Get(token);
            if (tk != null && tk.ExpiredAt == null)
            {
                return tk.Type;
            }
            return 0;

        }
        public static bool Logout(TokenModel tk)
        {
            var d_tk = DataAccessFactory.GetTokenDataAccess().Get(tk.Token1);
            d_tk.ExpiredAt = DateTime.Now;
            return DataAccessFactory.GetTokenDataAccess().Update(d_tk);

        }

    }
}
