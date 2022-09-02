namespace Labb1_MVCRazor.Models
{
    public interface ICustomerRepository
    {
        IEnumerable<Customer> GetAllCustomers { get; }
        Customer GetCustomerById(int id);
        Customer EditCustomer(Customer customer);
        Customer CreateCustomer(Customer newCustomer);
        Customer RemoveCustomer(Customer customer);
        IEnumerable<BookLoan> GetBookLoans(Customer customer);
    }
}
