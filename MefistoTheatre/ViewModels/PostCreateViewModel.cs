using MefistoTheatre.Models;
using System.ComponentModel.DataAnnotations;

namespace MefistoTheatre.ViewModels
{
    public class PostCreateViewModel
    {
        public string? PostId { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Summary { get; set; }

        [Required]
        public string? Content { get; set; }
        [Required(ErrorMessage = "Category is required.")]
        public string? CategoryId { get; set; }

        public IEnumerable<Category>? Categories { get; set; }
    }
}
