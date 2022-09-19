

using Microsoft.EntityFrameworkCore;

namespace Labb1_MVCRazor.Models
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbcontext;

        public BookRepository(AppDbContext appDbContext)
        {
            _appDbcontext = appDbContext;
        }
        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            //Thread.Sleep(2000); //TODO For testing load-page
            return await _appDbcontext.Books.ToListAsync(); 
        }

        public async Task<Book> AddBook(Book newBook)
        {
            await _appDbcontext.Books.AddAsync(newBook);
            await _appDbcontext.SaveChangesAsync();
            return newBook;
        }

        public async Task<BookItem> AddBookItem(BookItem bookItem)
        {
            await _appDbcontext.BookItems.AddAsync(bookItem);
            await _appDbcontext.SaveChangesAsync();
            return bookItem;
        }

        public async Task<Book> EditBook(Book book)
        {
            _appDbcontext.Books.Update(book);
            await _appDbcontext.SaveChangesAsync();
            return book;
        }

        public async Task<Book> GetBookById(int id)
        {
            return await _appDbcontext.Books.Include(b => b.BookItems).ThenInclude(b => b.BookLoans).ThenInclude(c => c.Customer).FirstOrDefaultAsync(b => b.BookId == id); //TODO Can I split this up?
        }

       
        public async Task<Book> GetBookByIsbn(string ISBN)
        {
            return await _appDbcontext.Books.FirstOrDefaultAsync(b => b.ISBN == ISBN);
        }

        public async Task<IEnumerable<BookItem>> GetAvailableBooksItemsByISBN(string ISBN)
        {
            var books = await _appDbcontext.BookItems.Include(l => l.BookLoans).Where(b => b.Book.ISBN == ISBN).ToListAsync();
            List<BookItem> availableBooks = new List<BookItem>();
            foreach (BookItem book in books)
            {
                if (book.BookLoans.Count > 0)
                {
                    var orderedLoans = book.BookLoans.OrderByDescending(d => d.LoanDate).ToList(); ;
                    if (orderedLoans[0].ReturnDate > DateTime.Parse("0001-01-01"))
                        availableBooks.Add(book);
                }
                else
                    availableBooks.Add(book);
            }
            return availableBooks;
        }

        public async Task<Book> RemoveBook(Book book)
        {
            if (book.BookItems.Count > 0)
            {
                foreach(BookItem bookItem in book.BookItems.ToList()) //TODO the bookLoans will crash?
                {
                    await RemoveBookItem(bookItem.BookItemId);
                }
            }
            _appDbcontext.Books.Remove(book);
            await _appDbcontext.SaveChangesAsync();
            return book;
        }
        public async Task<BookItem> RemoveBookItem(int bookItemId)
        {
            var toRemove = await _appDbcontext.BookItems.FirstOrDefaultAsync(b => b.BookItemId == bookItemId);
            _appDbcontext.BookItems.Remove(toRemove);
            await _appDbcontext.SaveChangesAsync();
            return toRemove;
        }
    }
}
