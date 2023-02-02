using MefistoTheatre.Models;
using System.ComponentModel.DataAnnotations;

namespace MefistoTheatre.ViewModels.Blog
{
    public class BlogDetailsViewModel
    {
        public string? PostId { get; set; }
        public string? Title { get; set; }
        public string? Summary { get; set; }
        public string? Content { get; set; }
        public string? AuthorName { get; set; }
        public DateTime? PublishedAt { get; set; }
        public ICollection<BlogCommentViewModel>? Comments { get; set; }

        [Required]
        public string? NewCommentContent { get; set; }
    }
}
