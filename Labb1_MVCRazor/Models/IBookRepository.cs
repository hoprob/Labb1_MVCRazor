namespace Labb1_MVCRazor.Models
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookById(int id);
        Task<Book> GetBookByIsbn(string isbn);
        Task<IEnumerable<BookItem>> GetAvailableBooksItemsByISBN(string ISBN);
        Task<Book> AddBook(Book newBook);
        Task<BookItem> AddBookItem(BookItem bookItem);
        Task<Book> EditBook(Book book);
        Task<Book> RemoveBook(Book book);
        Task<BookItem> RemoveBookItem(int bookItemId);
    }
}
