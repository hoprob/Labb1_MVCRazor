using Labb1_MVCRazor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labb1_MVCRazor.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IActionResult ListBooks()
        {
            var books = _bookRepository.GetAllBooks;
            return View(books);
        }
        public IActionResult BookPage(int bookId)
        {
            var book = _bookRepository.GetBookById(bookId);
            return View(book);
        }
    }
}
