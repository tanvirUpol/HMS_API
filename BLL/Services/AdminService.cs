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
    public class AdminService
    {
        
        public static List<AdminModel> Get()
        {
            var data = DataAccessFactory.GetAdminDataAccess().Get();
            var rdata = new List<AdminModel>();

            foreach (var item in data)
            {
                rdata.Add(new AdminModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Email = item.Email,
                    Password = item.Password,
                    Phone = item.Phone,
                    Type = item.Type,


                });
                
            }
            return rdata;
        }

        public static AdminModel Get(int id)
        {
            var data = DataAccessFactory.GetAdminDataAccess().Get(id);
            var rdata = new AdminModel();
            rdata.Id = data.Id;
            rdata.Name = data.Name;
            rdata.Email = data.Email;
            rdata.Phone = data.Phone;
            rdata.Type = data.Type;
            rdata.Password = data.Password;
      
            return rdata;
        }

        public static bool Create(AdminModel item)
        {
            var admin = new Admin()
            {
                Email = item.Email,
                Name = item.Name,
                Password = item.Password,
                Phone = item.Phone,
                Type = 1
                
            };
            return DataAccessFactory.GetAdminDataAccess().Create(admin);    
        }

        public static bool Update(AdminModel item)
        {
            var admin = new Admin()
            {
                Id = item.Id,
                Email = item.Email,
                Name = item.Name,
                Password = item.Password,
                Phone = item.Phone,
                Type = 1

            };
            return DataAccessFactory.GetAdminDataAccess().Update(admin);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetAdminDataAccess().Delete(id);
            return data;
        }


    }
}
