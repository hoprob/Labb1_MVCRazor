

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

        public Book EditBook(Book book)
        {
            _appDbcontext.Books.Update(book);
            _appDbcontext.SaveChanges();
            return book;
        }

        public Book GetBookById(int id)
        {
            return _appDbcontext.Books.Include(b => b.BookItems).FirstOrDefault(b => b.BookId == id);
        }

        public Book GetBookByIsbn(string isbn)
        {
            return _appDbcontext.Books.FirstOrDefault(b => b.ISBN == isbn);
        }

        public Book RemoveBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
