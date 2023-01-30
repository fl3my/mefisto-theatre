using MefistoTheatre.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MefistoTheatre.ViewModels
{
    public class ReviewPostSearchViewModel
    {
        public List<ReviewPostViewModel>? Posts { get; set; }
        public PostStatus? Status { get; set; }
        public string? SearchString { get; set; }
    }
}
