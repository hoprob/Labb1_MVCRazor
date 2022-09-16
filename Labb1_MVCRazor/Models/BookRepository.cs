

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
        public IEnumerable<Book> GetAllBooks => _appDbcontext.Books;

        public Book AddBook(Book newBook)
        {
            _appDbcontext.Add(newBook);
            _appDbcontext.SaveChanges();
            return newBook;
        }

        public BookItem AddBookItem(BookItem bookItem)
        {
            _appDbcontext.BookItems.Add(bookItem);
            _appDbcontext.SaveChanges();
            return bookItem;
        }

        public Book EditBook(Book book)
        {
            _appDbcontext.Books.Update(book);
            _appDbcontext.SaveChanges();
            return book;
        }

        public Book GetBookById(int id)
        {
            return _appDbcontext.Books.Include(b => b.BookItems).ThenInclude(b => b.BookLoans).ThenInclude(c => c.Customer).FirstOrDefault(b => b.BookId == id); //TODO Can I split this up?
        }

       
        public Book GetBookByIsbn(string ISBN)
        {
            return _appDbcontext.Books.FirstOrDefault(b => b.ISBN == ISBN);
        }

        public IEnumerable<BookItem> GetAvailableBooksItemsByISBN(string ISBN)
        {
            var books = _appDbcontext.BookItems.Include(l => l.BookLoans).Where(b => b.Book.ISBN == ISBN);
            List<BookItem> availableBooks = new List<BookItem>();
            foreach (BookItem book in books)
            {
                if (book.BookLoans.Count > 0)
                {
                    var orderedLoans = book.BookLoans.OrderByDescending(d => d.LoanDate).ToList();
                    if (orderedLoans[0].ReturnDate > DateTime.Parse("0001-01-01"))
                        availableBooks.Add(book);
                }
                else
                    availableBooks.Add(book);
            }
            return availableBooks;
        }

        public Book RemoveBook(Book book)
        {
            if (book.BookItems.Count > 0)
            {
                foreach(BookItem bookItem in book.BookItems.ToList()) //TODO the bookLoans will crash?
                {
                    RemoveBookItem(bookItem.BookItemId);
                }
            }
            _appDbcontext.Books.Remove(book);
            _appDbcontext.SaveChanges();
            return book;
        }
        public BookItem RemoveBookItem(int bookItemId)
        {
            var toRemove = _appDbcontext.BookItems.FirstOrDefault(b => b.BookItemId == bookItemId);
            _appDbcontext.BookItems.Remove(toRemove);
            _appDbcontext.SaveChanges();
            return toRemove;
        }
    }
}
