using MefistoTheatre.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MefistoTheatre.ViewModels
{
    public class AdminSearchViewModel
    {
        public List<AdminViewModel>? Posts { get; set; }
        public PostStatus? Status { get; set; }
        public string? SearchString { get; set; }
    }
}
