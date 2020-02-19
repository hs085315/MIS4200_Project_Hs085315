using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_Project_Hs085315.Models
{
    public class Student
    {
        public System.Guid SID { get; set; }
        public int studentId { get; set; }

        [Display (Name="First name")]
        public string studentFirstName { get; set; }

        [Display (Name="Last name")]
        public string studentLastName { get; set; }

        [Display(Name = "Most used email address")]
        public string email { get; set; }

        [Display(Name = "Mobile phone number")]
        public string phone { get; set; }

        [Display(Name = "When did you join this school?")]
        public DateTime studentSince { get; set; }
        public ICollection<Grade> Grade { get; set; }

        public string studentFullName
        {
            get
            {
                return studentFirstName + ", " + studentLastName;
            }
        }
    }
}