using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace keshivStudyGroup.Models
{
    public class keshivStudyGroupParticipant
    {

        [Key]
        [Display(Name = "Student Number")]
        public string StudentID { get; set; } 

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }  

        [Required]
        [Display(Name = "Surname")]
        public string Surname { get; set; }  

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string StudentEmail { get; set; }
    }
}