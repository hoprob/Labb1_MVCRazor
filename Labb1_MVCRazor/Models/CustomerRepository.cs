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

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _appDbContext.Customers.ToListAsync();
        }

        public async Task<Customer> CreateCustomer(Customer newCustomer)
        {
            var customer = await _appDbContext.Customers.AddAsync(newCustomer);
            await _appDbContext.SaveChangesAsync();
            return customer.Entity;
        }

        public async Task<Customer> EditCustomer(Customer customer)
        {            
            _appDbContext.Update(customer);
            await _appDbContext.SaveChangesAsync();
            return customer;
        }

        public async Task<IEnumerable<BookLoan>> GetBookLoans(Customer customer)
        {
            var bookLoans = (await _appDbContext.Customers.FirstOrDefaultAsync(c => c.CustomerId == customer.CustomerId)).BookLoans;
            return bookLoans;
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            return await _appDbContext.Customers.Include(c => c.BookLoans).ThenInclude(b => b.BookItem).ThenInclude(b => b.Book).FirstOrDefaultAsync(c => c.CustomerId == id);
        }

        public async Task<Customer> GetCustomerByUserId(string userId)

        {
            var user = await _appDbContext.Users.Include(c => c.Customer).FirstOrDefaultAsync(u => u.Id == userId);

            return user.Customer;
        }

        public async Task<Customer> GetCustomerByUserIdIncludeBookLoan(string userId)

        {
            var user = await _appDbContext.Users.Include(c => c.Customer).ThenInclude(b => b.BookLoans).ThenInclude(b => b.BookItem).ThenInclude(b => b.Book).FirstOrDefaultAsync(u => u.Id == userId);

            return user.Customer;
        }

        public async Task<Customer> RemoveCustomer(Customer customer)
        {
            var toRemove = await _appDbContext.Customers.FirstOrDefaultAsync(c => c.CustomerId == customer.CustomerId);
            _appDbContext.Customers.Remove(toRemove);
            await _appDbContext.SaveChangesAsync();
            return toRemove;
        }
    }
}
