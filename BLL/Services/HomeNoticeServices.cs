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
    public class HomeNoticeServices
    {
        public static List<HomeNoticeModel> Get()
        {
            var data = DataAccessFactory.GetHomeNoticeDataAccess().Get();
            var rdata = new List<HomeNoticeModel>();

            foreach (var item in data)
            {
                rdata.Add(new HomeNoticeModel()
                {
                    Id = item.Id,
                    Notice = item.Notice,
                    


                });

            }
            return rdata;
        }

        public static List<HomeNoticeModel> Get5()
        {
            var data = DataAccessFactory.GetHomeNoticeDataAccess().Get().Take(5);
            var rdata = new List<HomeNoticeModel>();

            foreach (var item in data)
            {
                rdata.Add(new HomeNoticeModel()
                {
                    Id = item.Id,
                    Notice = item.Notice,



                });

            }
            return rdata;
        }

        public static HomeNoticeModel Get(int id)
        {
            var data = DataAccessFactory.GetHomeNoticeDataAccess().Get(id);
            var rdata = new HomeNoticeModel();
            rdata.Id = data.Id;
            rdata.Notice = data.Notice;
            

            return rdata;
        }

        public static bool Create(HomeNoticeModel item)
        {
            var homeNotice = new HomeNotice()
            {
                Notice = item.Notice,

            };
            return DataAccessFactory.GetHomeNoticeDataAccess().Create(homeNotice);
        }

        public static bool Update(HomeNoticeModel item)
        {
            var homeNotice = new HomeNotice()
            {
                Id = item.Id,
                Notice = item.Notice

            };
            return DataAccessFactory.GetHomeNoticeDataAccess().Update(homeNotice);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetHomeNoticeDataAccess().Delete(id);
            return data;
        }
    }
}
