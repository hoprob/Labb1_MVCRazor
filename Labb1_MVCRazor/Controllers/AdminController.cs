using Labb1_MVCRazor.Models;
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
            return View(_books.GetBookById(id));
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

    }
}
