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
        [Required(ErrorMessage = "Student first name is required")]
        [StringLength(20)]
        public string studentFirstName { get; set; }

        [Display (Name="Last name")]
        [Required]
        [StringLength(20)]
        public string studentLastName { get; set; }

        [Display(Name = "Most used email address")]
        [Required]
        [EmailAddress(ErrorMessage = "Enter your most frequently used email address")]
        public string email { get; set; }

        [Display(Name = "Mobile phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) | \d{3}-)\d{3}-\d{4}$",
            ErrorMessage ="Phone numbers must be in the format xxx-xxx-xxxx")]
        public string phone { get; set; }

        [Display(Name = "What date did you start school?")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyy}" , ApplyFormatInEditMode =true)]
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