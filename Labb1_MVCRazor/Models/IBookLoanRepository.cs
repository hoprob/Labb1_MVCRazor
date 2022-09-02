namespace Labb1_MVCRazor.Models
{
    public interface IBookLoanRepository
    {
        IEnumerable<BookLoan> GetAllBookLoans { get; }
        BookLoan GetBookLoanById(int id);
        BookLoan AddBookLoan(BookLoan newBookLoan);
        BookLoan EditBookLoan(BookLoan bookLoan, BookLoan newData);
    }
}
