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
    public class StaffTaskServices
    {
        public static List<StaffTaskModel> Get()
        {
            var data = DataAccessFactory.GetStaffTaskDataAccess().Get();
            var rdata = new List<StaffTaskModel>();

            foreach (var item in data)
            {
                rdata.Add(new StaffTaskModel()
                {
                    Id = item.Id,
                    Staff_Id = item.Staff_Id,
                    Task = item.Task,
                    Status = item.Status,



                }); ;

            }
            return rdata;
        }

        public static StaffTaskModel Get(int id)
        {
            var data = DataAccessFactory.GetStaffTaskDataAccess().Get(id);
            var rdata = new StaffTaskModel();
            rdata.Id = data.Id;
            rdata.Staff_Id = data.Staff_Id;
            rdata.Task = data.Task;
            rdata.Status = data.Status; 

            return rdata;
        }

        public static bool Create(StaffTaskModel item)
        {
            var staffTask = new StaffTask()
            {
                Task = item.Task,
                Staff_Id=item.Staff_Id,
                Status = item.Status,
                

            };
            return DataAccessFactory.GetStaffTaskDataAccess().Create(staffTask);
        }

        public static bool Update(StaffTaskModel item)
        {
            var staffTask = new StaffTask()
            {
                Id = item.Id,
                Task = item.Task,
                Staff_Id = item.Staff_Id,
                Status = item.Status,

            };
            return DataAccessFactory.GetStaffTaskDataAccess().Update(staffTask);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetStaffTaskDataAccess().Delete(id);
            return data;
        }

    }
}
