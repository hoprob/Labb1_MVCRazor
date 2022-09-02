using System.ComponentModel.DataAnnotations;

namespace Labb1_MVCRazor.Models
{//TODO Check the attributes and erroir messages
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Firstname must be min. 2 and max. 25 characters!")]
        public string CustomerFirstName { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "Lastname must be min. 2 and max. 25 characters!")]
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string Address { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 4)]
        public string ZipCode { get; set; }
        [Required]
        [StringLength(70, MinimumLength = 2)]
        public string City { get; set; }
        public List<BookLoan> BookLoans { get; set; }
    }
}
