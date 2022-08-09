using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BOs
{
    public class StaffTaskModel
    {
        public int Id { get; set; }
        public int Staff_Id { get; set; }
        public string Task { get; set; }
        public string Status { get; set; }
    }
}
