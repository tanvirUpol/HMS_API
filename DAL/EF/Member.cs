//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        public Member()
        {
            this.In_Out_Notes = new HashSet<In_Out_Notes>();
            this.MealInfos = new HashSet<MealInfo>();
            this.Member_Complains = new HashSet<Member_Complains>();
            this.Request_Services = new HashSet<Request_Services>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public string Gname { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public int Type { get; set; }
        public int Room_Id { get; set; }
    
        public virtual ICollection<In_Out_Notes> In_Out_Notes { get; set; }
        public virtual ICollection<MealInfo> MealInfos { get; set; }
        public virtual ICollection<Member_Complains> Member_Complains { get; set; }
        public virtual RoomDetail RoomDetail { get; set; }
        public virtual ICollection<Request_Services> Request_Services { get; set; }
    }
}
