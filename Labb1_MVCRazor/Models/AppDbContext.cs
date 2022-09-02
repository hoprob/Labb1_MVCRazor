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

            modelBuilder.Entity<Book>().HasData(new Book { BookId = 1, BookTitle = "Sapiens", BookAuthor = "Yuval Noah Harari", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AmountInLibrary = 2 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 2, BookTitle = "Snabba Cash", BookAuthor = "Jens Lapidus", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AmountInLibrary = 3 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 3, BookTitle = "Kungshjärta", BookAuthor = "Lars Wilderäng", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AmountInLibrary = 1 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 4, BookTitle = "Svart Historia", BookAuthor = "Amat Levin", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AmountInLibrary = 2 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 5, BookTitle = "Paradis City", BookAuthor = "Jens Lapidus", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AmountInLibrary = 1 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 6, BookTitle = "Stjärnfall", BookAuthor = "Loise Boije af Gennäs", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AmountInLibrary = 4 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 7, BookTitle = "Livet efter 40 : En guide för män", BookAuthor = "Nisse Edwall", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AmountInLibrary = 2 });
            modelBuilder.Entity<Book>().HasData(new Book { BookId = 8, BookTitle = "Svartfågel", BookAuthor = "Frida Skybäck", BookDescription = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", AmountInLibrary = 1 });

            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 1, BookId = 7, CustomerId = 2, LoanDate = DateTime.Parse("2022-05-05"), DueDate = DateTime.Parse("2022-06-05") });
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 2, BookId = 5, CustomerId = 3, LoanDate = DateTime.Parse("2022-07-29"), DueDate = DateTime.Parse("2022-08-29"),});
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 3, BookId = 6, CustomerId = 1, LoanDate = DateTime.Parse("2022-08-20"), DueDate = DateTime.Parse("2022-09-20"),});
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 4, BookId = 3, CustomerId = 4, LoanDate = DateTime.Parse("2022-08-03"), DueDate = DateTime.Parse("2022-09-03"), ReturnDate = DateTime.Parse("2022-08-29") });
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 5, BookId = 2, CustomerId = 2, LoanDate = DateTime.Parse("2022-06-23"), DueDate = DateTime.Parse("2022-07-23"), ReturnDate = DateTime.Parse("2022-07-13") });
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 6, BookId = 6, CustomerId = 5, LoanDate = DateTime.Parse("2022-02-01"), DueDate = DateTime.Parse("2022-03-01"), ReturnDate = DateTime.Parse("2022-02-22") });
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 7, BookId = 7, CustomerId = 1, LoanDate = DateTime.Parse("2021-12-13"), DueDate = DateTime.Parse("2022-01-13")});
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 8, BookId = 1, CustomerId = 5, LoanDate = DateTime.Parse("2022-03-15"), DueDate = DateTime.Parse("2022-04-15"), ReturnDate = DateTime.Parse("2022-04-10") });
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 9, BookId = 2, CustomerId = 3, LoanDate = DateTime.Parse("2022-08-31"), DueDate = DateTime.Parse("2022-09-30")});
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 10, BookId = 4, CustomerId = 4, LoanDate = DateTime.Parse("2022-01-02"), DueDate = DateTime.Parse("2022-02-02")});
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 11, BookId = 1, CustomerId = 2, LoanDate = DateTime.Parse("2022-07-01"), DueDate = DateTime.Parse("2022-08-01"), ReturnDate = DateTime.Parse("2022-07-29") });
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 12, BookId = 7, CustomerId = 5, LoanDate = DateTime.Parse("2022-05-06"), DueDate = DateTime.Parse("2022-06-06"), ReturnDate = DateTime.Parse("2022-06-01") });
            modelBuilder.Entity<BookLoan>().HasData(new BookLoan { BookLoanId = 13, BookId = 1, CustomerId = 4, LoanDate = DateTime.Parse("2022-06-23"), DueDate = DateTime.Parse("2022-07-23"), ReturnDate = DateTime.Parse("2022-07-20") });
        }
    }
}
