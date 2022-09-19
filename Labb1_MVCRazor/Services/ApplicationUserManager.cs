using Labb1_MVCRazor.Migrations;
using Labb1_MVCRazor.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Labb1_MVCRazor.Services
{
    public class ApplicationUserManager : UserManager<ApplicationUser>
    {
        private readonly ICustomerRepository _customers;
        public ApplicationUserManager(ICustomerRepository customers, IUserStore<ApplicationUser> store, IOptions<IdentityOptions> optionsAccessor, IPasswordHasher<ApplicationUser> passwordHasher, IEnumerable<IUserValidator<ApplicationUser>> userValidators, IEnumerable<IPasswordValidator<ApplicationUser>> passwordValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<ApplicationUser>> logger) : base(store, optionsAccessor, passwordHasher, userValidators, passwordValidators, keyNormalizer, errors, services, logger)
        {
            _customers = customers;
        }
        public async Task<string> GetUserFullName(string userId)
        {
            var customer = await _customers.GetCustomerByUserId(userId);
            return customer == null ? "No Name" : customer.CustomerFirstName + " " + customer.CustomerLastName;
        }
    }
}
