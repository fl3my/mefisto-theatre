using System.ComponentModel.DataAnnotations;

namespace MefistoTheatre.Enums
{
    public enum PostStatus
    {
        Draft,
        [Display(Name = "To be Reviewed")]
        ToBeReviewed,
        Published
    }
}
