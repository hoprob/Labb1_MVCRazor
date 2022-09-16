namespace Labb1_MVCRazor.Models
{
    public class BookLoanRepository : IBookLoanRepository
    {
        private readonly AppDbContext _appDbContext;

        public BookLoanRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<BookLoan> GetAllBookLoans => _appDbContext.BookLoans;

        public BookLoan AddBookLoan(BookLoan newBookLoan)
        {
            _appDbContext.BookLoans.Add(newBookLoan);
            _appDbContext.SaveChanges();
            return newBookLoan;
        }
        public BookLoan GetBookLoanById(int id)
        {
            var bookLoan = _appDbContext.BookLoans.FirstOrDefault(b => b.BookLoanId == id);
            return bookLoan;
        }

        public BookLoan EditBookLoan(BookLoan bookLoan)
        {
            var updatedLoan = _appDbContext.BookLoans.Update(bookLoan).Entity;
            _appDbContext.SaveChanges();
            return updatedLoan;
        }
    }
}
