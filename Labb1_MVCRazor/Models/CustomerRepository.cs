using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Labb1_MVCRazor.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _appDbContext;

        public CustomerRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Customer> GetAllCustomers => _appDbContext.Customers;

        public Customer CreateCustomer(Customer newCustomer)
        {
            _appDbContext.Customers.Add(newCustomer);
            _appDbContext.SaveChanges();
            return newCustomer;
        }

        public Customer EditCustomer(Customer customer, Customer newCustomerData)
        {
            var customerToEdit = _appDbContext.Customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
            customerToEdit.CustomerFirstName = newCustomerData.CustomerFirstName;
            customerToEdit.CustomerLastName = newCustomerData.CustomerLastName;
            customerToEdit.CustomerEmail = newCustomerData.CustomerEmail;
            _appDbContext.SaveChanges();
            return customerToEdit;
        }

        public IEnumerable<BookLoan> GetBookLoans(Customer customer)
        {
            var bookLoans = _appDbContext.Customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId).BookLoans;
            return bookLoans;
        }

        public Customer GetCustomerById(int id)
        {
            return _appDbContext.Customers.Include(c => c.BookLoans).ThenInclude(b => b.Book).FirstOrDefault(c => c.CustomerId == id);
        }

        public Customer RemoveCustomer(Customer customer)
        {
            var toRemove = _appDbContext.Customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
            _appDbContext.Customers.Remove(toRemove);
            return toRemove;
        }
    }
}
