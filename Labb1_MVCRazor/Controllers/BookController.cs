using Labb1_MVCRazor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labb1_MVCRazor.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        private readonly IBookLoanRepository _bookLoans;
        public BookController(IBookRepository bookRepository, IBookLoanRepository bookLoans)
        {
            _bookRepository = bookRepository;
            _bookLoans = bookLoans;
        }
        public async Task<IActionResult> ListBooks()
        {
            var books = await _bookRepository.GetAllBooks();
            return View(books);
        }
        public IActionResult BookPage(int bookId)
        {
            var book = _bookRepository.GetBookById(bookId);
            return View(book);
        }

        
    }
}
