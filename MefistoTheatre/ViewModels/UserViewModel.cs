using System.ComponentModel.DataAnnotations;

namespace MefistoTheatre.ViewModels
{
    public class UserViewModel
    {
        public string? UserId { get; set; }
        [Display(Name = "Full name")]
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }
        public string? RoleColour { get; set; }
        [Display(Name = "Suspended")]
        public bool IsSuspended { get; set; }
    }
}
