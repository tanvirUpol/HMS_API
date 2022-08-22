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
    public class RequestServServices
    {
        public static List<RequestServiceModel> Get()
        {
            var data = DataAccessFactory.GetRequestServiceDataAccess().Get();
            var rdata = new List<RequestServiceModel>();

            foreach (var item in data)
            {
                rdata.Add(new RequestServiceModel()
                {
                    Id = item.Id,
                    Member_Id = item.Member_Id,
                    Service= item.Service,

                });

            }
            return rdata;
        }

        public static RequestServiceModel Get(int id)
        {
            var data = DataAccessFactory.GetRequestServiceDataAccess().Get(id);
            var rdata = new RequestServiceModel();
           

            rdata.Id = data.Id;
            rdata.Member_Id = data.Member_Id;
            rdata.Service = data.Service;
           
            return rdata;
        }

        public static bool Create(RequestServiceModel item)
        {
            var rs = new Request_Services()
            {
                Id = item.Id,
                Member_Id = item.Member_Id,
                Service = item.Service

            };
            return DataAccessFactory.GetRequestServiceDataAccess().Create(rs);
        }


        public static bool Update(RequestServiceModel item)
        {
            var rs = new Request_Services()
            {
                Id = item.Id,
                Member_Id = item.Member_Id,
                Service = item.Service


            };
            return DataAccessFactory.GetRequestServiceDataAccess().Update(rs);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetRequestServiceDataAccess().Delete(id);
            return data;
        }


    }
}
