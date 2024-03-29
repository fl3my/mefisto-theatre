﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace MefistoTheatre.ViewModels.Blog
{
    public class BlogSearchViewModel
    {
        public List<BlogViewModel>? Posts { get; set; }
        public string? SearchTitle { get; set; }
        public string? SearchAuthor { get; set; }
        public string? SearchCategory { get; set; }
        public SelectList? Categories { get; set; }
    }
}
