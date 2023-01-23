﻿using Microsoft.AspNetCore.Mvc.Rendering;

namespace MefistoTheatre.Models
{
    public class UserSearchViewModel
    {
        public List<UserViewModel>? Users { get; set; }
        public SelectList? Roles { get; set; }
        public string? UserRole { get; set; }
        public string? SearchString { get; set; }
    }
}
