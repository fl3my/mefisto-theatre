using Microsoft.AspNetCore.Mvc.Rendering;

namespace MefistoTheatre.ViewModels.Blog
{
    public class BlogSearchViewModel
    {
        public List<BlogViewModel>? Posts { get; set; }
        public string? SearchString { get; set; }

    }
}
