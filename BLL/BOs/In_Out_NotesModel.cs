﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BOs
{
    public class In_Out_NotesModel
    {
        public int Id { get; set; }
        public string DateAndTime { get; set; }
        public int Member_id { get; set; }
        public string Status { get; set; }
    }
}
