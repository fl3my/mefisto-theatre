using MefistoTheatre.Models;

namespace MefistoTheatre.ViewModels
{
    public class PostEditViewModel
    {
        public string? PostId { get; set; }
        public string? Title { get; set; }
        public string? Summary { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime PublishedAt { get; set; }
        public bool Published { get; set; }
        public string? Content { get; set; }

        public string? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
