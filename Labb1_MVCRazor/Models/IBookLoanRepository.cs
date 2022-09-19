namespace Labb1_MVCRazor.Models
{
    public interface IBookLoanRepository
    {
        Task<IEnumerable<BookLoan>> GetAllBookLoans();
        Task<BookLoan> GetBookLoanById(int id);
        Task<BookLoan> AddBookLoan(BookLoan newBookLoan);
        Task<BookLoan> EditBookLoan(BookLoan bookLoan);
    }
}
