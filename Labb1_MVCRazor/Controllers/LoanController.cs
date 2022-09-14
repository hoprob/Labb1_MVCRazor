using Labb1_MVCRazor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labb1_MVCRazor.Controllers
{
    public class LoanController : Controller
    {
        private readonly IBookLoanRepository _bookLoans;
        private readonly ICustomerRepository _customers;
        private readonly IBookRepository _books;

        public LoanController(IBookLoanRepository bookLoans, ICustomerRepository customers, IBookRepository books)
        {
            _bookLoans = bookLoans;
            _customers = customers;
            _books = books;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult NewBookLoan(string bookISBN)
        {
            var book = _books.GetBookByIsbn(bookISBN);
            return View(book);
        }

        [HttpPost]
        public IActionResult NewBookLoan(string bookISBN, string userId)
        {
            var booksAvailable = _books.GetAvailableBooksItemsByISBN(bookISBN).ToList();
            var customer = _customers.GetCustomerByUserId(userId);
            if (booksAvailable.Count() > 0)
            {
                _bookLoans.AddBookLoan(new BookLoan { BookItemId = booksAvailable[0].BookItemId, CustomerId = customer.CustomerId, LoanDate = DateTime.Now, DueDate = DateTime.Now.AddDays(30) });
                return RedirectToAction("ListBooks", "Book");
            }
            return View();
        }
    }
}
