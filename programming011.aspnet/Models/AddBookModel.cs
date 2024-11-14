using System.ComponentModel.DataAnnotations;

namespace programming011.aspnet.Models
{
    public class AddBookModel
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Genre { get; set; }
        [Range(1, 100000, ErrorMessage = "The number of pages should be bigger than zero")]
        public int Pages { get; set; }
        public DateTime PublishedDate { get; set; }
        [Required]
        public string AuthorName { get; set; }
    }
}
