using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BOs
{
    public class MemberModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Gname { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public int Type { get; set; }
        public int Room_Id { get; set; }
    }
}
