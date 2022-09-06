using System.ComponentModel.DataAnnotations;

namespace Labb1_MVCRazor.Models
{
    public class BookItem
    {
        [Key]
        public int BookItemId { get; set; }
        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; }
        public List<BookLoan> BookLoans { get; set; }
    }
}
