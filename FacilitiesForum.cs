//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EOTTTSMPCOWNZ.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FacilitiesForum
    {
        public int FacilitiesForumId { get; set; }
        public string FullName { get; set; }
        public Nullable<int> PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string Agenda { get; set; }
        public Nullable<System.DateTime> ForumDate { get; set; }
        public int CouncilId { get; set; }
    
        public virtual Council Council { get; set; }
    }
}
