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
        public async Task<IActionResult> CustomerPage(int id)
        {
            var customer = await _customers.GetCustomerById(id);
            return View(customer);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditCustomer(int id)
        {
            return View(await _customers.GetCustomerById(id));
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> EditCustomer(Customer customer)
        {
            //if (ModelState.IsValid)
            //{
            await _customers.EditCustomer(customer);
            return RedirectToAction("CustomerPage", new { id = customer.CustomerId });
            //}
            //return View(customer);
        }
        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddCustomer(Customer customer)
        {
            await _customers.CreateCustomer(customer);
            return RedirectToAction("ListCustomers");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ListCustomers(string sortOrder = "")
        {
            var customers = await _customers.GetAllCustomers();
            switch (sortOrder)
            {
                case ("fName"):
                    {
                        customers = customers.OrderBy(c => c.CustomerFirstName);
                        break;
                    }
                case ("fNameDesc"):
                    {
                        customers = customers.OrderByDescending(c => c.CustomerFirstName);
                        break;
                    }
                case ("lName"):
                    {
                        customers = customers.OrderBy(c => c.CustomerLastName);
                        break;
                    }
                case ("lNameDesc"):
                    {
                        customers = customers.OrderByDescending(c => c.CustomerLastName);
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return View(customers);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var toDelete = await _customers.GetCustomerById(id);
            if(toDelete != null)
            {
                await _customers.RemoveCustomer(toDelete);
            }
            return RedirectToAction("ListCustomers");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ListBooks()
        {
            return View(await _books.GetAllBooks());
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AdminBookPage(int id)
        {
            var book = await _books.GetBookById(id);
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
        public async Task<IActionResult> AddBook(AddBookViewModel bookViewModel)
        {
            var book = await _books.AddBook(bookViewModel.Book);
            for (int i = 0; i < bookViewModel.BookItemAmount; i++)
            {
                await _books.AddBookItem(new BookItem { BookId = book.BookId });
            }
            return RedirectToAction("ListBooks");
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> AddBookItems(int bookId, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                await _books.AddBookItem(new BookItem { BookId = bookId });
            }
            return RedirectToAction("AdminBookPage", new { id = bookId });
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> EditBook(int id)
        {
            var bookToUpdate = await _books.GetBookById(id);
            return View(bookToUpdate);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> EditBook(Book book)
        {
            await _books.EditBook(book);
            return RedirectToAction("AdminBookPage", new { id = book.BookId });
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RemoveBook(int bookId)
        {
            await _books.RemoveBook(await _books.GetBookById(bookId));
            return RedirectToAction("ListBooks");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RemoveBookItem(int bookItemId, int bookId)
        {
            await _books.RemoveBookItem(bookItemId);
            return RedirectToAction("AdminBookPage", new { id = bookId });
        }
    }
}
