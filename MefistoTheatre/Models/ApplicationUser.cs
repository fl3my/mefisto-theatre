using Microsoft.AspNetCore.Identity;

namespace MefistoTheatre.Models
{
    public class ApplicationUser : IdentityUser
    {
        // PersonalData tag allows the user to retrieve the data on the frontend.
        [PersonalData]
        public string? FirstName { get; set; }
        [PersonalData]
        public string? LastName { get; set; }
        [PersonalData]
        public string? Address { get; set; }
        [PersonalData]
        public string? City { get; set; }
        [PersonalData]
        public string? PostCode { get; set; }
        [PersonalData]
        public DateTime DateOfBirth { get; set; }
        public bool IsSuspended { get; set; }
        public DateTime Joined { get; set; }

        public ICollection<Post>? Posts { get; set; }
    }
}
