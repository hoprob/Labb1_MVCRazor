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
            //Checks if it is a get request, to render page w. placeholders before data.
            if (Request.Headers["x-requested-with"] == "XMLHttpRequest")
            {
                var books = await _bookRepository.GetAllBooks();
                return PartialView("_listBooks", books);
            }
            return View();
        }
        public async Task<IActionResult> BookPage(int bookId)
        {
            var book = await _bookRepository.GetBookById(bookId);
            return View(book);
        }

        
    }
}
