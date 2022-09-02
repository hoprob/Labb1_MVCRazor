using Labb1_MVCRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Runtime.CompilerServices;

namespace Labb1_MVCRazor.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICustomerRepository _customers;
        public AdminController(ICustomerRepository customers)
        {
            _customers = customers;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListCustomers()
        {
            return View(_customers.GetAllCustomers);
        }
        public IActionResult CustomerPage(int id)
        {
            var customer = _customers.GetCustomerById(id);
            return View(customer);
        }
    }
}
