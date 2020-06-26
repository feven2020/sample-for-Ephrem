using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Yayobe.Models
{
    public class StudentModel
    {
        [Display(Name ="Student ID")]
        [Range(1, 999999, ErrorMessage = "Enter a valid SudentID")]
        public int userid { get; set; }
        [Display(Name = "Frist Name")]
        [Required(ErrorMessage = "Enter Frist Name")]
        public string Fristname { get; set; }
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Enter Last Name")]
        public string Lastname { get; set; }
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Enter Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Emailaddress { get; set; }
        [Display(Name = "Confirm Email")]
        
        public string ConfirmEmail { get; set; }
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Enter Password that is long enough minumum of 5 letters")]
        [DataType(DataType.Password)]
        [StringLength(10,MinimumLength = 5)]
        public string password{ get; set; }
        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        
        public string confirmpassword { get; set; }
    }
}