using Labb1_MVCRazor.Models;

namespace Labb1_MVCRazor.ViewModels
{
    public class AdminBookIPageViewModel
    {
        public Book Book { get; set; }
        public IEnumerable<BookItemViewModel> BookItems { get; set; }
    }
}
