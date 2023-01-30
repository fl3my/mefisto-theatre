using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace MefistoTheatre.ViewModels.User
{
    public class UserEditViewModel
    {
        public string? UserId { get; set; }
        [Display(Name = "First name")]
        public string? FirstName { get; set; }
        [Display(Name = "First name")]

        public string? LastName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]

        public DateTime DateOfBirth { get; set; }

        public string? Email { get; set; }
        public string? Role { get; set; }
        [Display(Name = "Suspended?")]
        public bool IsSuspended { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Joined")]

        public DateTime Joined { get; set; }

        public SelectList? Roles { get; set; }
    }
}
