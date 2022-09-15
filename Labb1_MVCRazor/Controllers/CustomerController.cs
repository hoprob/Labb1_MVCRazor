using Labb1_MVCRazor.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Labb1_MVCRazor.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customers;

        public CustomerController(ICustomerRepository customers)
        {
            _customers = customers;
        }

        public IActionResult CustomerPage(string userId)
        {
            var customer = _customers.GetCustomerByUserIdIncludeBookLoan(userId);
            return View(customer);
        }

        public IActionResult EditCustomer(int id)
        {
            return View(_customers.GetCustomerById(id));
        }

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
    }
}
