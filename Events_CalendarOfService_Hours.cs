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
    
    public partial class Events_CalendarOfService_Hours
    {
        public int EventId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public string ThemeColor { get; set; }
        public Nullable<bool> IsFullDay { get; set; }
        public int CouncilId { get; set; }
    
        public virtual Council Council { get; set; }
    }
}