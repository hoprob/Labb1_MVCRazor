using Labb1_MVCRazor.Models;
using Labb1_MVCRazor.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Runtime.CompilerServices;

namespace Labb1_MVCRazor.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICustomerRepository _customers;
        private readonly IBookRepository _books;
        public AdminController(ICustomerRepository customers, IBookRepository books)
        {
            _customers = customers;
            _books = books;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult CustomerPage(int id)
        {
            var customer = _customers.GetCustomerById(id);
            return View(customer);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult EditCustomer(int id)
        {
            return View(_customers.GetCustomerById(id));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult EditCustomer(Customer customer)
        {
            //if (ModelState.IsValid)
            //{
            _customers.EditCustomer(customer);
            return RedirectToAction("CustomerPage", new { id = customer.CustomerId });
            //}
            //return View(customer);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _customers.CreateCustomer(customer);
            return RedirectToAction("ListCustomers");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult ListCustomers()
        {
            return View(_customers.GetAllCustomers);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult DeleteCustomer(int id)
        {
            var toDelete = _customers.GetCustomerById(id);
            if(toDelete != null)
            {
                _customers.RemoveCustomer(toDelete);
            }
            return RedirectToAction("ListCustomers");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ListBooks()
        {
            return View(await _books.GetAllBooks());
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AdminBookPage(int id)
        {
            var book = _books.GetBookById(id);
            var bookItems = new List<BookItemViewModel>();
            foreach (var bookItem in book.BookItems)
            {
                bookItems.Add(new BookItemViewModel { BookItem = bookItem, BookItemId = bookItem.BookItemId, BookId = bookItem.BookId, BookLoans = bookItem.BookLoans});
            }
            var viewModel = new AdminBookIPageViewModel { Book = book, BookItems = bookItems };
            return View(viewModel);
        }

        [Authorize(Roles = "Admin")]
        public IActionResult AddBook()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddBook(AddBookViewModel bookViewModel)
        {
            var book = _books.AddBook(bookViewModel.Book);
            for (int i = 0; i < bookViewModel.BookItemAmount; i++)
            {
                _books.AddBookItem(new BookItem { BookId = book.BookId });
            }
            return RedirectToAction("ListBooks");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult AddBookItems(int bookId, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                _books.AddBookItem(new BookItem { BookId = bookId });
            }
            return RedirectToAction("AdminBookPage", new { id = bookId });
        }

        [Authorize(Roles = "Admin")]
        public IActionResult EditBook(int id)
        {
            var bookToUpdate = _books.GetBookById(id);
            return View(bookToUpdate);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult EditBook(Book book)
        {
            _books.EditBook(book);
            return RedirectToAction("AdminBookPage", new { id = book.BookId });
        }

        [Authorize(Roles = "Admin")]
        public IActionResult RemoveBook(int bookId)
        {
            _books.RemoveBook(_books.GetBookById(bookId));
            return RedirectToAction("ListBooks");
        }

        [Authorize(Roles = "Admin")]
        public IActionResult RemoveBookItem(int bookItemId, int bookId)
        {
            _books.RemoveBookItem(bookItemId);
            return RedirectToAction("AdminBookPage", new { id = bookId });
        }
    }
}
