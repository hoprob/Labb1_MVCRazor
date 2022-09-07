using Labb1_MVCRazor.Models;
using Labb1_MVCRazor.ViewModels;
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
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            _customers.CreateCustomer(customer);
            return RedirectToAction("ListCustomers");
        }

        public IActionResult ListCustomers()
        {
            return View(_customers.GetAllCustomers);
        }

        public IActionResult DeleteCustomer(int id)
        {
            var toDelete = _customers.GetCustomerById(id);
            if(toDelete != null)
            {
                _customers.RemoveCustomer(toDelete);
            }
            return RedirectToAction("ListCustomers");
        }

        public IActionResult ListBooks()
        {
            return View(_books.GetAllBooks);
        }

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

        public IActionResult AddBook()
        {
            return View();
        }

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

        [HttpPost]
        public IActionResult AddBookItems(int bookId, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                _books.AddBookItem(new BookItem { BookId = bookId });
            }
            return RedirectToAction("AdminBookPage", new { id = bookId });
        }

        public IActionResult EditBook(int id)
        {
            var bookToUpdate = _books.GetBookById(id);
            return View(bookToUpdate);
        }
        [HttpPost]
        public IActionResult EditBook(Book book)
        {
            _books.EditBook(book);
            return RedirectToAction("AdminBookPage", new { id = book.BookId });
        }

        public IActionResult RemoveBook(int bookId)
        {
            _books.RemoveBook(_books.GetBookById(bookId));
            return RedirectToAction("ListBooks");
        }

        public IActionResult RemoveBookItem(int bookItemId, int bookId)
        {
            _books.RemoveBookItem(bookItemId);
            return RedirectToAction("AdminBookPage", new { id = bookId });
        }
    }
}
