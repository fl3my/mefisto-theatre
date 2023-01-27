using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MefistoTheatre.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string PostId { get; set; }
        public string? Title { get; set; }
        public string? Summary { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime PublishedAt { get; set; }
        public bool Published { get; set; }
        public string? Content { get; set; }

    }
}
