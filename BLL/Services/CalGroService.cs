using BLL.BOs;
using DAL.EF;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BLL.Services
{
    public class CalGroService
    {
        public static List<CalGroModel> Get()
        {
            var data = DataAccessFactory.GetCalGroDataAccess().Get();
            var rdata = new List<CalGroModel>();

            foreach (var item in data)
            {
                rdata.Add(new CalGroModel()
                {
                    Id = item.Id,
                    Date = item.Date,
                    Price = item.Price,
                    Product = item.Product,

                });

            }
            return rdata;
        }

        public static CalGroModel Get(int id)
        {
            var data = DataAccessFactory.GetCalGroDataAccess().Get(id);
            var rdata = new CalGroModel();
            rdata.Id = data.Id;
            rdata.Date = data.Date;
            rdata.Price = data.Price;
            rdata.Product = data.Product;
            return rdata;
        }

        public static bool Create(CalGroModel item)
        {
            var calgro = new CalGro()
            {
                Date = item.Date,
                Price = item.Price,
                Product = item.Product,

            };
            return DataAccessFactory.GetCalGroDataAccess().Create(calgro);
        }

        public static bool Update(CalGroModel item)
        {
            var calgro = new CalGro()
            {
                Id = item.Id,
                Date = item.Date,
                Price = item.Price,
                Product = item.Product,
            };
            return DataAccessFactory.GetCalGroDataAccess().Update(calgro);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetCalGroDataAccess().Delete(id);
            return data;
        }

        public static float TotalBazar()
        {
            float x=0;


            var data = DataAccessFactory.GetCalGroDataAccess().Get();
            //var rdata = new List<CalGroModel>();

            foreach (var item in data)
            {
                x=+item.Price;
            }
            return x;
        }
    }
}
