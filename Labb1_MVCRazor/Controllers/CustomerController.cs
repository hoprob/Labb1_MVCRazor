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

        public async Task<IActionResult> CustomerPage(string userId)
        {
            var customer = await _customers.GetCustomerByUserIdIncludeBookLoan(userId);
            return View(customer);
        }

        public async Task<IActionResult> EditCustomer(int id)
        {
            return View(await _customers.GetCustomerById(id));
        }

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

    }
}
