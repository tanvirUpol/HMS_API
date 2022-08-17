using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BOs
{
    public class MealInfoModel
    {
        public int Id { get; set; }
        public int Member_Id { get; set; }
        public int Lunch { get; set; }
        public int Dinner { get; set; }
        public int Breakfast { get; set; }
    }
}
