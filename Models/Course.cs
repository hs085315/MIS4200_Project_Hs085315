using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MIS4200_Project_Hs085315.Models
{
    public class Course
    {
        public int courseId { get; set; }

        [Display(Name = "Course description")]
        [Required(ErrorMessage = "Please provide course description")]
        [StringLength(200)]

        public string description { get; set; }

        [Display(Name = "Date of first class")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]

        public DateTime courseDate { get; set; }

        public ICollection<Grade> Grade { get; set; } 

    }
}