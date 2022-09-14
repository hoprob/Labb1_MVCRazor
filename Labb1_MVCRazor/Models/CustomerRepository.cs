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
            var customer = _appDbContext.Customers.Add(newCustomer);
            _appDbContext.SaveChanges();
            return customer.Entity;
        }

        public Customer EditCustomer(Customer customer)
        {
            //TODO If update function is ok, remove the commented parts....
            //customerToUpdate.CustomerFirstName = customer.CustomerFirstName; 
            //var customerToUpdate = GetCustomerById(customer.CustomerId);
            //customerToUpdate.CustomerLastName = customer.CustomerLastName;
            //customerToUpdate.Address = customer.Address;
            //customerToUpdate.CustomerEmail = customer.CustomerEmail;
            //customerToUpdate.City = customer.City;
            //customerToUpdate.Phone = customer.Phone;
            //customerToUpdate.ZipCode = customer.ZipCode;
            _appDbContext.Update(customer);
            
            _appDbContext.SaveChanges();
            //return customerToUpdate;
            return customer;
        }

        public IEnumerable<BookLoan> GetBookLoans(Customer customer)
        {
            var bookLoans = _appDbContext.Customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId).BookLoans;
            return bookLoans;
        }

        public Customer GetCustomerById(int id)
        {
            return _appDbContext.Customers.Include(c => c.BookLoans).ThenInclude(b => b.BookItem).ThenInclude(b => b.Book).FirstOrDefault(c => c.CustomerId == id);
        }

        public Customer GetCustomerByUserId(string userId)

        {
            var user = _appDbContext.Users.Include(c => c.Customer).FirstOrDefault(u => u.Id == userId);

            return user.Customer;
        }

        public Customer RemoveCustomer(Customer customer)
        {
            var toRemove = _appDbContext.Customers.FirstOrDefault(c => c.CustomerId == customer.CustomerId);
            _appDbContext.Customers.Remove(toRemove);
            _appDbContext.SaveChanges();
            return toRemove;
        }
    }
}
