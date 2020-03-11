using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MentorshipApi.Models.Database
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [Required(ErrorMessage ="Your name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Your Nape Id * is required")]
        [Display(Name="NAPE ID*")]
        public string NapeId { get; set; }
        [Required(ErrorMessage = "Your Email is required")]
        [Display(Name = "Email*")]
        public string Email { get; set; }
        [Display(Name = "Area of Specializations")]
        public string AreaofSpecializations  { get; set; }
        [Display(Name= "School (for undergratuade / postgraduate student only)")]
        public Schools Schools { get; set; }
        [Display(Name = "Level (for undergratuade / postgraduate student only)")]
        public Levels Levels { get; set; }
        [Display(Name="Organization")]
        public string Organization { get; set; }
        [Display(Name="Years of Experience")]
        public int YearsOfExperience { get; set; }
        public MembershipTypes MembershipTypes { get; set; }
    }
}
