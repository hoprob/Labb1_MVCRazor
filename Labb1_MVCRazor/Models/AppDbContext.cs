using Microsoft.EntityFrameworkCore;

namespace Labb1_MVCRazor.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        //DbSets
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookItem> BookItems { get; set; }
        public DbSet<BookLoan> BookLoans { get; set; }

        //OnModelCreating

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 1, CustomerFirstName = "Jan", CustomerLastName = "Banan", CustomerEmail = "janbanan72@outlook.com", Phone="0765349563", Address = "Stormgatan 5", ZipCode = "43562", City = "Varberg" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 2, CustomerFirstName = "Sara", CustomerLastName = "Hellström", CustomerEmail = "shellstom@gmail.com", Phone = "0796145632", Address = "Hejgatan 88", ZipCode = "54961", City = "Gaiscity" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 3, CustomerFirstName = "Margret", CustomerLastName = "von Kallsup", CustomerEmail = "mvk@adel.se", Phone = "0766666666", Address = "Fintskadevagatan 44", ZipCode = "66666", City = "Snobbcity" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 4, CustomerFirstName = "Glenn", CustomerLastName = "Glennsson", CustomerEmail = "feskegottanna@gbg.com", Phone = "0795164856", Address = "Avenyn 1", ZipCode = "31265", City = "Götlaborg" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 5, CustomerFirstName = "Sven", CustomerLastName = "Fransson", CustomerEmail = "svenisvang@hotmail.com", Phone = "0794653865", Address = "Svängen 1", ZipCode = "45623", City = "Landet" });
            modelBuilder.Entity<Customer>().HasData(new Customer { CustomerId = 6, CustomerFirstName = "Johanna", CustomerLastName = "Stenström", CustomerEmail = "famousj@gmail.com", Phone = "0716532965", Address = "Engata 3", ZipCode = "16946", City = "Enstad" });

            modelBuilder.Entity<Book>().HasData(new Book { BookId = 1, ISBN = "9780099590088", BookTitle = "Sapiens", ImageURL= "/Images/sapiens.jpg", BookAuthor = "Yuval Noah Harari", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."});
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 2, ISBN = "9789170016400", BookTitle = "Snabba Cash", ImageURL = "/Images/snabba-cash.jpg", BookAuthor = "Jens Lapidus", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."});
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 3, ISBN = "9789113113432", BookTitle = "Kungshjärta", ImageURL = "/Images/kungshjärta.jpg", BookAuthor = "Lars Wilderäng", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."});
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 4, ISBN = "9789127173194", BookTitle = "Svart Historia", ImageURL = "/Images/svart-historia.jpg", BookAuthor = "Amat Levin", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."});
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 5, ISBN = "9789100196424", BookTitle = "Paradis City", ImageURL = "/Images/paradis-city.jpg", BookAuthor = "Jens Lapidus", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."});
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 6, ISBN = "9789113113982", BookTitle = "Stjärnfall", ImageURL = "/Images/stjärnfall.jpg", BookAuthor = "Loise Boije af Gennäs", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."});
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 7, ISBN = "9789177958369", BookTitle = "Livet efter 40 : En guide för män", ImageURL = "/Images/livet-efter-40--en-guide-för-män.jpg", BookAuthor = "Nisse Edwall", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."});
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 8, ISBN = "9789177956327", BookTitle = "Svartfågel", ImageURL = "/Images/svartfågel.jpg", BookAuthor = "Frida Skybäck", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum."});
           
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 1, BookId = 1 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 2, BookId = 1 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 3, BookId = 2 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 4, BookId = 2 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 5, BookId = 2 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 6, BookId = 2 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 7, BookId = 2 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 8, BookId = 3 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 9, BookId = 3 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 10, BookId = 3 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 11, BookId = 4 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 12, BookId = 5 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 13, BookId = 5 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 14, BookId = 6 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 15, BookId = 6 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 16, BookId = 7 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 17, BookId = 7 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 18, BookId = 7 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 19, BookId = 8 });
            modelBuilder.Entity<BookItem>().HasData(new BookItem { BookItemId = 20, BookId = 8 });

            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 1, BookItemId = 1, CustomerId = 2, LoanDate = DateTime.Parse("2022-05-05"), DueDate = DateTime.Parse("2022-06-05") });
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 2, BookItemId = 18, CustomerId = 3, LoanDate = DateTime.Parse("2022-07-29"), DueDate = DateTime.Parse("2022-08-29"),});
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 3, BookItemId = 15, CustomerId = 1, LoanDate = DateTime.Parse("2022-08-20"), DueDate = DateTime.Parse("2022-09-20"),});
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 4, BookItemId = 4, CustomerId = 4, LoanDate = DateTime.Parse("2022-08-03"), DueDate = DateTime.Parse("2022-09-03"), ReturnDate = DateTime.Parse("2022-08-29") });
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 5, BookItemId = 5, CustomerId = 2, LoanDate = DateTime.Parse("2022-06-23"), DueDate = DateTime.Parse("2022-07-23"), ReturnDate = DateTime.Parse("2022-07-13") });
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 6, BookItemId = 19, CustomerId = 5, LoanDate = DateTime.Parse("2022-02-01"), DueDate = DateTime.Parse("2022-03-01"), ReturnDate = DateTime.Parse("2022-02-22") });
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 7, BookItemId = 2, CustomerId = 1, LoanDate = DateTime.Parse("2021-12-13"), DueDate = DateTime.Parse("2022-01-13")});
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 8, BookItemId = 16, CustomerId = 5, LoanDate = DateTime.Parse("2022-03-15"), DueDate = DateTime.Parse("2022-04-15"), ReturnDate = DateTime.Parse("2022-04-10") });
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 9, BookItemId = 11, CustomerId = 3, LoanDate = DateTime.Parse("2022-08-31"), DueDate = DateTime.Parse("2022-09-30")});
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 10, BookItemId = 9, CustomerId = 4, LoanDate = DateTime.Parse("2022-01-02"), DueDate = DateTime.Parse("2022-02-02")});
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 11, BookItemId = 8, CustomerId = 2, LoanDate = DateTime.Parse("2022-07-01"), DueDate = DateTime.Parse("2022-08-01"), ReturnDate = DateTime.Parse("2022-07-29") });
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 12, BookItemId = 7, CustomerId = 5, LoanDate = DateTime.Parse("2022-05-06"), DueDate = DateTime.Parse("2022-06-06"), ReturnDate = DateTime.Parse("2022-06-01") });
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 13, BookItemId = 3, CustomerId = 4, LoanDate = DateTime.Parse("2022-06-23"), DueDate = DateTime.Parse("2022-07-23"), ReturnDate = DateTime.Parse("2022-07-20") });
        }
    }
}
