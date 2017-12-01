using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace website.Models
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}", ApplyFormatInEditMode = true)]
        [Display(Name = "Date Written")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime DateWritten { get; set; }

        [Display(Name = "Subject")]
        [StringLength(50, MinimumLength = 2)]
        [Required]
        public string BlogSubject { get; set; }

        [Display(Name = "Contents")]
        [StringLength(1000, MinimumLength = 20)]
        [Required]
        public string BlogContents { get; set; }
    }
}