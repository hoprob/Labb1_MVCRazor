using Microsoft.EntityFrameworkCore;

namespace Labb1_MVCRazor.Models
{
    public class BookLoanRepository : IBookLoanRepository
    {
        private readonly AppDbContext _appDbContext;

        public BookLoanRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<IEnumerable<BookLoan>> GetAllBookLoans()
        {
            return await _appDbContext.BookLoans.ToListAsync();
        } 
        public async Task<BookLoan> AddBookLoan(BookLoan newBookLoan)
        {
            await _appDbContext.BookLoans.AddAsync(newBookLoan);
            await _appDbContext.SaveChangesAsync();
            return newBookLoan;
        }
        public async Task<BookLoan> GetBookLoanById(int id)
        {
            var bookLoan = await _appDbContext.BookLoans.FirstOrDefaultAsync(b => b.BookLoanId == id);
            return bookLoan;
        }

        public async Task<BookLoan> EditBookLoan(BookLoan bookLoan)
        {
            var updatedLoan = _appDbContext.BookLoans.Update(bookLoan).Entity;
            await _appDbContext.SaveChangesAsync();
            return updatedLoan;
        }
    }
}
