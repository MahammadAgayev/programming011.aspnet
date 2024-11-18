namespace programming011.aspnet.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? CoverImage { get; set; }
        public string Title { get; set; }
        public string? Description { get; set; }
        public string? Genre { get; set; }
        public int Pages { get; set; }
        public int ReleaseYear { get; set; }
        public string? AuthorName { get; set; }
    }
}
