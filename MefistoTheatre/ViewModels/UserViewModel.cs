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
        [Display(Name = "Suspended?")]
        public bool IsSuspended { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date Joined")]

        public DateTime Joined { get; set; }
    }
}
