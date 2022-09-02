using System.ComponentModel.DataAnnotations;

namespace Labb1_MVCRazor.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookTitle { get; set; }
        [Required]
        public string BookAuthor { get; set; }
        public string BookDescription { get; set; }
        [Required]
        public int AmountInLibrary { get; set; }
        public List<BookLoan> BookLoans { get; set; }
    }
}
