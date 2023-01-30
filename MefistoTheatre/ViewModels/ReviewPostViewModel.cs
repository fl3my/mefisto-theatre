﻿using MefistoTheatre.Enums;

namespace MefistoTheatre.ViewModels
{
    public class ReviewPostViewModel
    {
        public string? PostId { get; set; }
        public string? Title { get; set; }
        public string? AuthorName { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime PublishedAt { get; set; }
        public PostStatus Status { get; set; }
    }
}