using Labb1_MVCRazor.Models;

namespace Labb1_MVCRazor.ViewModels
{
    public class BookItemViewModel
    {
        public int BookItemId { get; set; }
        public BookItem BookItem { get; set; }
        public IEnumerable<BookLoan> BookLoans { get; set; } //TODO Rewrite to last bookloan....
        public int BookId { get; set; }
        public bool IsAvailable { get { return Available(BookLoans); } }
        public bool IsLate { get { return IsBookLate(BookLoans); } }
        public Customer Customer { get { return GetCustomer(BookLoans); } }
        public DateTime DueDate { get { return GetDueDate(BookLoans); } }

        public bool Available(IEnumerable<BookLoan> loans)
        {
            var orderedList = loans.OrderBy(d => d.LoanDate).ToList(); 
            if (orderedList.Count > 0)
            {
                if (orderedList[0].ReturnDate > DateTime.Parse("0001-01-01"))
                    return true;
                else
                    return false;
            }
            else
                return true;
        }
        public bool IsBookLate(IEnumerable<BookLoan> bookLoans)
        {
            var orderedList = bookLoans.OrderBy(d => d.LoanDate).ToList();
            if (orderedList.Count > 0)
            {
                if (orderedList[0].DueDate < DateTime.Now)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public Customer GetCustomer(IEnumerable<BookLoan> bookLoans)
        {
            var orderedList = bookLoans.OrderBy(d => d.LoanDate).ToList();
            if (orderedList.Count > 0)
                return orderedList[0].Customer;
            else
                return null;
        }

        public DateTime GetDueDate(IEnumerable<BookLoan> bookLoans)
        {
            var orderedList = bookLoans.OrderBy(d => d.LoanDate).ToList();
            if (orderedList.Count > 0)
                return orderedList[0].DueDate;
            else
                return DateTime.Parse("0001-01-01");
        }
    }
}
