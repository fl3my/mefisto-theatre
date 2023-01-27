using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MefistoTheatre.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string CommentId { get; set; }
        public string? Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime PublishedAt { get; set; }
        public bool Published { get; set; }
        public string? Content { get; set; }
    }
}
