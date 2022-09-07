namespace Labb1_MVCRazor.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks { get; }
        Book GetBookById(int id);
        Book GetBookByIsbn(string isbn);
        Book AddBook(Book newBook);
        BookItem AddBookItem(BookItem bookItem);
        Book EditBook(Book book);
        Book RemoveBook(Book book);
        BookItem RemoveBookItem(int bookItemId);
    }
}
