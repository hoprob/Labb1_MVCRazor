namespace Labb1_MVCRazor.Models
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Book GetBookById(int id);
        Book GetBookByIsbn(string isbn);
        IEnumerable<BookItem> GetAvailableBooksItemsByISBN(string ISBN);
        Book AddBook(Book newBook);
        BookItem AddBookItem(BookItem bookItem);
        Book EditBook(Book book);
        Book RemoveBook(Book book);
        BookItem RemoveBookItem(int bookItemId);
    }
}
