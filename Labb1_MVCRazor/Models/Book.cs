using System.ComponentModel.DataAnnotations;

namespace Labb1_MVCRazor.Models
{
    //TODO Check Placeholder when rendering books
    //TODO Jag var på att skriva ut status på böcker i AdminBookPage när jag slutade den 6/9 2022
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string BookTitle { get; set; }
        [Required]
        public string BookAuthor { get; set; }
        public string BookDescription { get; set; }
        public List<BookItem> BookItems { get; set; }
    }
}
