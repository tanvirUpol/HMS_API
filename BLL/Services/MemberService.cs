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
            var config = new MapperConfiguration(c =>
            c.CreateMap<Member, MemberModel>()
            );

            var mapper = new Mapper(config);
            var data = mapper.Map<List<MemberModel>>(DataAccessFactory.GetMemberDataAccess().Get());


            return data;
        }

        public static List<string> GetMember()
        {
            var data = DataAccessFactory.GetMemberDataAccess().Get().Select(e => e.Name).ToList();
            return data;
        }
        public static void Add(MemberModel m)
        {
            var config = new MapperConfiguration(c =>
            c.CreateMap<MemberModel, Member>()
            );

            var mapper = new Mapper(config);
            var data = mapper.Map<Member>(m);

        }

        public static void Delete(MemberModel m)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MemberModel, Member>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Member>(m);
            DataAccessFactory.GetMemberDataAccess().Delete(Convert.ToInt16(data));
            
        }

        public static void Edit(MemberModel m)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<MemberModel, Member>();

            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Member>(m);
            DataAccessFactory.GetMemberDataAccess().Update(data);
        }
    }
}
