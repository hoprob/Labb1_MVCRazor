using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Labb1_MVCRazor.Models
{
    public class BookLoan
    {
        [Key]
        public int BookLoanId { get; set; }
        [Required]
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        [Required]
        public int BookItemId { get; set; }
        public BookItem BookItem { get; set; }
        [Required]
        public DateTime LoanDate { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }

    }
}
