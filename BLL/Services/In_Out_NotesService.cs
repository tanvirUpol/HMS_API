using BLL.BOs;
using DAL.EF;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class In_Out_NotesService
    {
        public static List<In_Out_NotesModel> Get()
        {
            var data = DataAccessFactory.GetIn_Out_NotesDataAccess().Get();
            var rdata = new List<In_Out_NotesModel>();

            foreach (var item in data)
            {
                rdata.Add(new In_Out_NotesModel()
                {
                    Id = item.Id,
                    DateAndTime = item.DateAndTime,
                    Member_id = item.Member_id,
                    Status = item.Status,

                });

            }
            return rdata;
        }

        public static In_Out_NotesModel Get(int id)
        {
            var data = DataAccessFactory.GetIn_Out_NotesDataAccess().Get(id);
            var rdata = new In_Out_NotesModel();
            rdata.Id = data.Id;
            rdata.DateAndTime = data.DateAndTime;
            rdata.Member_id = data.Member_id;
            rdata.Status = data.Status;

            return rdata;
        }

        public static bool Create(In_Out_NotesModel item)
        {
            var in_Out_Notes = new In_Out_Notes()
            {
                DateAndTime = item.DateAndTime,
                Member_id = item.Member_id,
                Status = item.Status,

            };
            return DataAccessFactory.GetIn_Out_NotesDataAccess().Create(in_Out_Notes);
        }

        public static bool Update(In_Out_NotesModel item)
        {
            var in_Out_Notes = new In_Out_Notes()
            {
                Id = item.Id,
                DateAndTime = item.DateAndTime,
                Member_id = item.Member_id,
                Status = item.Status,

            };
            return DataAccessFactory.GetIn_Out_NotesDataAccess().Update(in_Out_Notes);
        }

        public static bool Delete(int id)
        {
            var data = DataAccessFactory.GetIn_Out_NotesDataAccess().Delete(id);
            return data;
        }

    }
}
