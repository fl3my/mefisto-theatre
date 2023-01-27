﻿namespace MefistoTheatre.ViewModels
{
    public class PostViewModel
    {
        public string? PostId { get; set; }
        public string? Title { get; set; }
        public string? Summary { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime PublishedAt { get; set; }
        public bool Published { get; set; }
    }
}