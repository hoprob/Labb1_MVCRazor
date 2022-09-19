// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Labb1_MVCRazor.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Labb1_MVCRazor.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ICustomerRepository _customers;

        public IndexModel(
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ICustomerRepository customers)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _customers = customers;
        }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            [Phone]
            [Display(Name = "Tele")]
            public string PhoneNumber { get; set; }
            [StringLength(25, MinimumLength = 2, ErrorMessage = "Förnamnet måste vara minst 2 bokstäver och max 25")]
            [Display(Name = "Förnamn")]
            public string FirstName { get; set; }
            [StringLength(25, MinimumLength = 2, ErrorMessage = "Efternamnet måste vara minst 2 bokstäver och max 25")]
            [Display(Name = "Efternamn")]
            public string LastName { get; set; }
            [StringLength(55, MinimumLength = 2, ErrorMessage = "Adressen måste vara minst 2 bokstäver och max 55")]
            [Display(Name = "Adress")]
            public string Address { get; set; }
            [StringLength(10, MinimumLength = 4, ErrorMessage = "Postnumret måste vara minst 4 tecken och max 10")]
            [Display(Name = "Postnummer")]
            public string ZipCode { get; set; }
            [StringLength(25, MinimumLength = 2, ErrorMessage = "Orten måste vara minst 2 bokstäver och max 25")]
            [Display(Name = "Ort")]
            public string City { get; set; }
        }

        private async Task LoadAsync(ApplicationUser user)
        {
            var customer = await _customers.GetCustomerByUserId(user.Id);
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = customer.Phone;
            var firstName = customer.CustomerFirstName;
            var lastName = customer.CustomerLastName;
            var address = customer.Address;
            var zipcode = customer.ZipCode;
            var city = customer.City;

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                ZipCode = zipcode,
                City = city
                
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }


            var customer = await _customers.GetCustomerByUserId(user.Id);
            var phoneNumber = customer.Phone;
            var firstName = customer.CustomerFirstName;
            var lastName = customer.CustomerLastName;
            var address = customer.Address;
            var zipcode = customer.ZipCode;
            var city = customer.City;
            if (Input.PhoneNumber != phoneNumber)
            {
                customer.Phone = Input.PhoneNumber;
                await _customers.EditCustomer(customer);
            }
            if(Input.FirstName != firstName)
            {
                user.Customer.CustomerFirstName = Input.FirstName;
                await _customers.EditCustomer(customer);
            }
            if (Input.LastName != lastName)
            {
                user.Customer.CustomerLastName = Input.LastName;
                await _customers.EditCustomer(customer);
            }
            if (Input.Address != address)
            {
                user.Customer.Address = Input.Address;
                await _customers.EditCustomer(customer);
            }
            if (Input.ZipCode != zipcode)
            {
                user.Customer.ZipCode = Input.ZipCode;
                await _customers.EditCustomer(customer);
            }
            if (Input.City != city)
            {
                user.Customer.City = Input.City;
                await _customers.EditCustomer(customer);
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
