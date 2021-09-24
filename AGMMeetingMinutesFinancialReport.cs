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
    using System.ComponentModel.DataAnnotations;

    public partial class AGMMeetingMinutesFinancialReport
    {
        public int DocumentId { get; set; }
        public string Name { get; set; }

        [Display(Name = "File Type")]
        [Required(ErrorMessage = "File Type is required.")]
        public string FileType { get; set; }
        public byte[] DataFiles { get; set; }


        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Create Date")]
        [Required(ErrorMessage = "Create Date is required.")]
        //[RegularExpression(@"(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$", ErrorMessage = "Invalid date format.")]
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public int CouncilId { get; set; }
    
        public virtual Council Council { get; set; }
    }
}
