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
        public string description { get; set; }
        public DateTime courseDate { get; set; }
        public int studentId { get; set; }
        public virtual Student Student { get; set; }
    }
}