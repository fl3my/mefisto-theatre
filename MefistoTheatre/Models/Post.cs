using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MefistoTheatre.Enums;

namespace MefistoTheatre.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? PostId { get; set; }
        public string? Title { get; set; }
        public string? Summary { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime? PublishedAt { get; set; }
        public PostStatus Status { get; set; }
        public string? Content { get; set; }

        public string? CategoryId { get; set; }
        public Category? Category { get; set; }
        public string? AuthorId { get; set; }
        public ApplicationUser? Author { get; set; }
        public ICollection<Comment>? Comments { get; set; }
    }
}
