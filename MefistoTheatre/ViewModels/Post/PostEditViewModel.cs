﻿using MefistoTheatre.Enums;
using MefistoTheatre.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MefistoTheatre.ViewModels.Post
{
    public class PostEditViewModel
    {
        public string? PostId { get; set; }
        public string? Title { get; set; }
        public string? Summary { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public DateTime? PublishedAt { get; set; }
        public PostStatus Status { get; set; }
        public SelectList? StatusSelect { get; set; }
        public string? Content { get; set; }

        public string? CategoryId { get; set; }
        public IEnumerable<Category>? Categories { get; set; }
    }
}