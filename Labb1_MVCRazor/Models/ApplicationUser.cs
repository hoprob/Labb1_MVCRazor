using Microsoft.AspNetCore.Identity;

namespace Labb1_MVCRazor.Models
{
    public class ApplicationUser : IdentityUser
    {
        public Customer Customer { get; set; }
    }
}
