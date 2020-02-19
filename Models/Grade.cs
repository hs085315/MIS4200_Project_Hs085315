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
        public string courseGrade { get; set; }

        // public decimal price { get; set; }

        // the next two properties link the orderDetail to the Order

        public int courseId { get; set; }

        public virtual Course Course { get; set; }

        // the next two properties link the orderDetail to the Product

        public int studentId { get; set; }

        public virtual Student Student { get; set; }
    }
}