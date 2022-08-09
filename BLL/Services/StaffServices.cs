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
    public class StaffServices
    {
        public static List<StaffModel> Get()
        {
            var data = DataAccessFactory.GetStaffDataAccess().Get();
            var rdata = new List<StaffModel>();

            foreach (var item in data)
            {
                rdata.Add(new StaffModel()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Age = item.Age,
                    Gender = item.Gender,
                    Address = item.Address,
                    Phone = item.Phone,
                    Password = item.Password,
                    Type = item.Type,

                });

            }
            return rdata;
        }

        public static StaffModel Get(int id)
        {
            var data = DataAccessFactory.GetStaffDataAccess().Get(id);
            var rdata = new StaffModel();
            rdata.Id = data.Id;
            rdata.Name = data.Name;
            rdata.Age = data.Age;
            rdata.Gender = data.Gender;
            rdata.Address = data.Address;
            rdata.Phone = data.Phone;
            rdata.Password = data.Password;
            rdata.Type = data.Type;

            return rdata;
        }

        public static bool Create(StaffModel item)
        {
            var staff = new Staff()
            {              
                Name = item.Name,
                Age = item.Age,
                Gender = item.Gender,
                Address = item.Address,
                Phone = item.Phone,
                Password = item.Password,
                Type = item.Type,

            };
            return DataAccessFactory.GetStaffDataAccess().Create(staff);
        }

        public static bool Update(StaffModel item)
        {
            var staff = new Staff()
            {
                Name = item.Name,
                Age = item.Age,
                Gender = item.Gender,
                Address = item.Address,
                Phone = item.Phone,
                Password = item.Password,
                Type = item.Type,

            };
            return DataAccessFactory.GetStaffDataAccess().Update(staff);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetStaffDataAccess().Delete(id);
            return data;
        }

    }
}
