namespace Labb1_MVCRazor.Models
{
    public interface ICustomerRepository
    {
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<Customer> GetCustomerById(int id);
        Task<Customer> GetCustomerByUserId(string userId);
        Task<Customer> GetCustomerByUserIdIncludeBookLoan(string userId);
        Task<Customer> EditCustomer(Customer customer);
        Task<Customer> CreateCustomer(Customer newCustomer);
        Task<Customer> RemoveCustomer(Customer customer);
        Task<IEnumerable<BookLoan>> GetBookLoans(Customer customer);
    }
}
