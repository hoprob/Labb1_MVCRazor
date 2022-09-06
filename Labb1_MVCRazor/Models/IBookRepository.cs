namespace Labb1_MVCRazor.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks { get; }
        Book GetBookById(int id);
        Book GetBookByIsbn(string isbn);
        Book AddBook(Book newBook);
        Book EditBook(Book book);
        Book RemoveBook(Book book);
    }
}
