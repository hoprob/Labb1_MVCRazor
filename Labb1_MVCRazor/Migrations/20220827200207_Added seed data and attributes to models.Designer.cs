// <auto-generated />
using System;
using Labb1_MVCRazor.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Labb1_MVCRazor.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220827200207_Added seed data and attributes to models")]
    partial class Addedseeddataandattributestomodels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Labb1_MVCRazor.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"), 1L, 1);

                    b.Property<int>("AmountInLibrary")
                        .HasColumnType("int");

                    b.Property<string>("BookAuthor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            AmountInLibrary = 2,
                            BookAuthor = "Yuval Noah Harari",
                            BookTitle = "Sapiens"
                        },
                        new
                        {
                            BookId = 2,
                            AmountInLibrary = 3,
                            BookAuthor = "Jens Lapidus",
                            BookTitle = "Snabba Cash"
                        },
                        new
                        {
                            BookId = 3,
                            AmountInLibrary = 1,
                            BookAuthor = "Lars Wilderäng",
                            BookTitle = "Kungshjärta"
                        },
                        new
                        {
                            BookId = 4,
                            AmountInLibrary = 2,
                            BookAuthor = "Amat Levin",
                            BookTitle = "Svart Historia"
                        },
                        new
                        {
                            BookId = 5,
                            AmountInLibrary = 1,
                            BookAuthor = "Jens Lapidus",
                            BookTitle = "Paradis City"
                        },
                        new
                        {
                            BookId = 6,
                            AmountInLibrary = 4,
                            BookAuthor = "Loise Boije af Gennäs",
                            BookTitle = "Stjärnfall"
                        },
                        new
                        {
                            BookId = 7,
                            AmountInLibrary = 2,
                            BookAuthor = "Nisse Edwall",
                            BookTitle = "Livet efter 40 : En guide för män"
                        },
                        new
                        {
                            BookId = 8,
                            AmountInLibrary = 1,
                            BookAuthor = "Frida Skybäck",
                            BookTitle = "Svartfågel"
                        });
                });

            modelBuilder.Entity("Labb1_MVCRazor.Models.BookLoan", b =>
                {
                    b.Property<int>("BookLoanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookLoanId"), 1L, 1);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("datetime2");

                    b.HasKey("BookLoanId");

                    b.HasIndex("BookId");

                    b.HasIndex("CustomerId");

                    b.ToTable("BookLoans");

                    b.HasData(
                        new
                        {
                            BookLoanId = 1,
                            BookId = 7,
                            CustomerId = 2,
                            DueDate = new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LoanDate = new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookLoanId = 2,
                            BookId = 5,
                            CustomerId = 3,
                            DueDate = new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LoanDate = new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookLoanId = 3,
                            BookId = 6,
                            CustomerId = 1,
                            DueDate = new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LoanDate = new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookLoanId = 4,
                            BookId = 3,
                            CustomerId = 4,
                            DueDate = new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LoanDate = new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookLoanId = 5,
                            BookId = 2,
                            CustomerId = 2,
                            DueDate = new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LoanDate = new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookLoanId = 6,
                            BookId = 6,
                            CustomerId = 5,
                            DueDate = new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LoanDate = new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookLoanId = 7,
                            BookId = 7,
                            CustomerId = 1,
                            DueDate = new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LoanDate = new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookLoanId = 8,
                            BookId = 1,
                            CustomerId = 5,
                            DueDate = new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LoanDate = new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookLoanId = 9,
                            BookId = 2,
                            CustomerId = 3,
                            DueDate = new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LoanDate = new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookLoanId = 10,
                            BookId = 4,
                            CustomerId = 4,
                            DueDate = new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LoanDate = new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookLoanId = 11,
                            BookId = 1,
                            CustomerId = 2,
                            DueDate = new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LoanDate = new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookLoanId = 12,
                            BookId = 7,
                            CustomerId = 5,
                            DueDate = new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LoanDate = new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            BookLoanId = 13,
                            BookId = 1,
                            CustomerId = 4,
                            DueDate = new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LoanDate = new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ReturnDate = new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Labb1_MVCRazor.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerFirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("CustomerLastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            CustomerEmail = "janbanan72@outlook.com",
                            CustomerFirstName = "Jan",
                            CustomerLastName = "Banan"
                        },
                        new
                        {
                            CustomerId = 2,
                            CustomerEmail = "shellstom@gmail.com",
                            CustomerFirstName = "Sara",
                            CustomerLastName = "Hellström"
                        },
                        new
                        {
                            CustomerId = 3,
                            CustomerEmail = "mvk@adel.se",
                            CustomerFirstName = "Margret",
                            CustomerLastName = "von Kallsup"
                        },
                        new
                        {
                            CustomerId = 4,
                            CustomerEmail = "feskegottanna@gbg.com",
                            CustomerFirstName = "Glenn",
                            CustomerLastName = "Glennsson"
                        },
                        new
                        {
                            CustomerId = 5,
                            CustomerEmail = "svenisvang@hotmail.com",
                            CustomerFirstName = "Sven",
                            CustomerLastName = "Fransson"
                        },
                        new
                        {
                            CustomerId = 6,
                            CustomerEmail = "famousj@gmail.com",
                            CustomerFirstName = "Johanna",
                            CustomerLastName = "Stenström"
                        });
                });

            modelBuilder.Entity("Labb1_MVCRazor.Models.BookLoan", b =>
                {
                    b.HasOne("Labb1_MVCRazor.Models.Book", "Book")
                        .WithMany("BookLoans")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Labb1_MVCRazor.Models.Customer", "Customer")
                        .WithMany("BookLoans")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Labb1_MVCRazor.Models.Book", b =>
                {
                    b.Navigation("BookLoans");
                });

            modelBuilder.Entity("Labb1_MVCRazor.Models.Customer", b =>
                {
                    b.Navigation("BookLoans");
                });
#pragma warning restore 612, 618
        }
    }
}
