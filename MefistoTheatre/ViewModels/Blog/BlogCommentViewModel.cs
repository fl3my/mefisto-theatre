namespace MefistoTheatre.ViewModels.Blog
{
    public class BlogCommentViewModel
    {
        public string? CommentId { get; set; }
        public string? AuthorName { get; set; }
        public string? AuthorId { get; set; }
        public DateTime PublishedAt { get; set; }
        public string? Content { get; set; }
    }
}
