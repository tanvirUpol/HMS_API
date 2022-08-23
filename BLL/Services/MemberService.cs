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
    public class MemberService
    {
        public static List<MemberModel> GetAllMember()
        {
            //var config = new MapperConfiguration(c =>
            //c.CreateMap<Member, MemberModel>()
            //);

            //var mapper = new Mapper(config);
            //var data = mapper.Map<List<MemberModel>>(DataAccessFactory.GetMemberDataAccess().Get());


            //return data;

            var data = DataAccessFactory.GetMemberDataAccess().Get();
            var rdata = new List<MemberModel>();

            foreach (var m in data)
            {
                rdata.Add(new MemberModel()
                {
                    Id = m.Id,
                    Name = m.Name,
                    Password = m.Password,
                    Age = m.Age,

                    Gname = m.Gname,
                    Gender = m.Gender,
                    Phone = m.Phone,

                    Type = 3,
                    Room_Id = m.Room_Id


                });

            }
            return rdata;



        }

        public static MemberModel Get(int id)
        {
            var m = DataAccessFactory.GetMemberDataAccess().Get(id);
            var rdata = new MemberModel();


            rdata.Id = m.Id;
            rdata.Name = m.Name;
            rdata.Password = m.Password;
            rdata.Age = m.Age;

            rdata.Gname = m.Gname;
            rdata.Gender = m.Gender;
            rdata.Phone = m.Phone;

            rdata.Type = 3;
            rdata.Room_Id = m.Room_Id;

            return rdata;
        }

        public static List<MemberModel> GetMember()
        {
            //var data = DataAccessFactory.GetMemberDataAccess().Get().Select(e => e.Name).ToList();
            //return data;

            var data = DataAccessFactory.GetMemberDataAccess().Get();
            var rdata = new List<MemberModel>();

            foreach (var m in data)
            {
                rdata.Add(new MemberModel()
                {
                    Id = m.Id,
                    Name = m.Name,
                    Password = m.Password,
                    Age = m.Age,

                    Gname = m.Gname,
                    Gender = m.Gender,
                    Phone = m.Phone,

                    Type = 3,
                    Room_Id = m.Room_Id



                });

            }
            return rdata;


        }
        public static bool Create(MemberModel m)
        {
            //var config = new MapperConfiguration(c =>
            //c.CreateMap<MemberModel, Member>()
            //);

            //var mapper = new Mapper(config);
            //var data = mapper.Map<Member>(m);
            //return DataAccessFactory.GetMemberDataAccess().Create(data);

            //if (data != 0)
            //{
            //    return true;
            //}
            //return false;
            var mem = new Member()
            {
                Id = m.Id,
                Name = m.Name,
                Password = m.Password,
                Age = m.Age,

                Gname = m.Gname,
                Gender = m.Gender,
                Phone = m.Phone,

                Type =3,
                Room_Id = m.Room_Id

            };
            return DataAccessFactory.GetMemberDataAccess().Create(mem);

        }

        public static bool Delete(int id)
        {
            //var config = new MapperConfiguration(c =>
            //{
            //    c.CreateMap<MemberModel, Member>();

            //});
            //var mapper = new Mapper(config);
            //var data = mapper.Map<Member>(m);
            //return DataAccessFactory.GetMemberDataAccess().Delete(Convert.ToInt16(data));
            ////Convert.ToInt16(data)
            ////return true;
            ///


            var data = DataAccessFactory.GetMemberDataAccess().Delete(id);

            return data;


        }

        public static  bool Update(MemberModel m)
        {
            //var config = new MapperConfiguration(c =>
            //{
            //    c.CreateMap<MemberModel, Member>();

            //});
            //var mapper = new Mapper(config);
            //var data = mapper.Map<Member>(m);

            //return DataAccessFactory.GetMemberDataAccess().Update(data);

            var mem = new Member()
            {
                Id = m.Id,
                Name = m.Name,
                Password = m.Password,
                Age = m.Age,
         
                Gname = m.Gname,
                Gender=m.Gender,
                Phone= m.Phone,

                Type = 3,
                Room_Id=m.Room_Id

            };
            return DataAccessFactory.GetMemberDataAccess().Update(mem);

        }
    }
}
