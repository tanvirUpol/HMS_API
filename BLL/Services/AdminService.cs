using BLL.BOs;
using DAL;
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
                    //   Password = item.Password,
                    Phone = item.Phone,
                    //  Type = item.Type,


                });
                
            }
            return rdata;
        }
    }
}
