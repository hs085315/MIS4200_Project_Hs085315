using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_Project_Hs085315.Models
{
    public class Grade
    {
        public int gradeId { get; set; }
        
        [Display (Name="Course grade")]
        [Required(ErrorMessage = "Course grade required")]
        [StringLength(20)]
        public string courseGrade { get; set; }

        // public decimal price { get; set; }

        // the next two properties link the orderDetail to the Order

        public int courseId { get; set; }

        [Display(Name = "Course")]
        [Required]

        public virtual Course Course { get; set; }

        // the next two properties link the orderDetail to the Product

        public int studentId { get; set; }

        public virtual Student Student { get; set; }
    
    }
}