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
    }
}
