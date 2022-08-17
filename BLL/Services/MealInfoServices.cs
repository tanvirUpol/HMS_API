using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BLL.BOs;
using DAL;
using DAL.EF;
using DAL.Repo;

namespace BLL.Services
{
    public class MealInfoServices
    {
        public static List<MealInfoModel> Get()
        {
            var data = DataAccessFactory.GetMealInfoDataAccess().Get();
            var rdata = new List<MealInfoModel>();

            foreach (var item in data)
            {
                rdata.Add(new MealInfoModel()
                {

                    Id = item.Id,
                    Member_Id = item.Member_Id,
                    Lunch = item.Lunch,
                    Dinner = item.Dinner,
                    Breakfast = item.Breakfast,

                });

            }
            return rdata;
        }

        public static MealInfoModel Get(int id)
        {
            var data = DataAccessFactory.GetMealInfoDataAccess().Get(id);
            var rdata = new MealInfoModel();
          

            rdata.Id = data.Id;
            rdata.Member_Id = data.Member_Id;
            rdata.Lunch = data.Lunch;
            rdata.Dinner = data.Dinner;
            rdata.Breakfast = data.Breakfast;

      
            return rdata;
        }

        public static bool Create(MealInfoModel item)
        {
            var mealInfo = new MealInfo()
            {
                Id = item.Id,
                Member_Id = item.Member_Id,
                Lunch = item.Lunch,
                Dinner = item.Dinner,
                Breakfast = item.Breakfast,

            };
            return DataAccessFactory.GetMealInfoDataAccess().Create(mealInfo);
        }

        public static bool Update(MealInfoModel item)
        {
            var mealInfo = new MealInfo()
            {
                Id = item.Id,
                Member_Id = item.Member_Id,
                Lunch = item.Lunch,
                Dinner = item.Dinner,
                Breakfast = item.Breakfast,

            };
            return DataAccessFactory.GetMealInfoDataAccess().Update(mealInfo);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetMealInfoDataAccess().Delete(id);
            return data;
        }


    }
}
