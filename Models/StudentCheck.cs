using System.ComponentModel.DataAnnotations;
using System;

namespace School.Models {
    public class StudentCheck {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your phone number")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Please specify semester")]
        [Range(1,5)]
        public int Semester { get; set; }
    }
}
