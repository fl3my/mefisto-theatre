﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MefistoTheatre.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? CommentId { get; set; }
        public string? Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime PublishedAt { get; set; }
        public bool Published { get; set; }
        public string? Content { get; set; }

        public string? PostId { get; set; }
        [Required]
        public Post? Post { get; set; }

        public string? AuthorId { get; set; }
        public ApplicationUser? Author { get; set; }

    }
}
