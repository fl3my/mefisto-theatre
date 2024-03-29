﻿using MefistoTheatre.Models;

namespace MefistoTheatre.ViewModels.Blog
{
    public class BlogViewModel
    {
        public string? PostId { get; set; }
        public string? Title { get; set; }
        public string? Summary { get; set; }
        public string? AuthorName { get; set; }
        public int CommentCount { get; set; }
        public DateTime? PublishedAt { get; set; }
        public Category? Category { get; set; }
    }
}
