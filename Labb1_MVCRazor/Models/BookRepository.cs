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

        public Book EditBook(Book book, Book newData)
        {
            throw new NotImplementedException();
        }

        public Book GetBookById(int id)
        {
            return _appDbcontext.Books.Find(id);
        }

        public Book RemoveBook(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
