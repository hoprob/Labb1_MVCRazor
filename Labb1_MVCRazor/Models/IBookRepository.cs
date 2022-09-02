namespace Labb1_MVCRazor.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks { get; }
        Book GetBookById(int id);
        Book AddBook(Book newBook);
        Book EditBook(Book book, Book newData);
        Book RemoveBook(Book book);
    }
}
