using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MefistoTheatre.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? CategoryId { get; set; }
        public string? CategoryName { get; set; }

        public ICollection<Post>? Posts { get; set; }
    }
}
