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
    
    public partial class RoomDetail
    {
        public RoomDetail()
        {
            this.Members = new HashSet<Member>();
        }
    
        public int Id { get; set; }
        public int RoomNo { get; set; }
        public int Capacity { get; set; }
        public int AssignedMember { get; set; }
        public int SeatAvailable { get; set; }
        public string RoomSpec { get; set; }
    
        public virtual ICollection<Member> Members { get; set; }
    }
}