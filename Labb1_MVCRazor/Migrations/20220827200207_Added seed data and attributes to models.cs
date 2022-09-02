using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb1_MVCRazor.Migrations
{
    public partial class Addedseeddataandattributestomodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReturned",
                table: "BookLoans");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerLastName",
                table: "Customers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerFirstName",
                table: "Customers",
                type: "nvarchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "AmountInLibrary",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "AmountInLibrary", "BookAuthor", "BookTitle" },
                values: new object[,]
                {
                    { 1, 2, "Yuval Noah Harari", "Sapiens" },
                    { 2, 3, "Jens Lapidus", "Snabba Cash" },
                    { 3, 1, "Lars Wilderäng", "Kungshjärta" },
                    { 4, 2, "Amat Levin", "Svart Historia" },
                    { 5, 1, "Jens Lapidus", "Paradis City" },
                    { 6, 4, "Loise Boije af Gennäs", "Stjärnfall" },
                    { 7, 2, "Nisse Edwall", "Livet efter 40 : En guide för män" },
                    { 8, 1, "Frida Skybäck", "Svartfågel" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerEmail", "CustomerFirstName", "CustomerLastName" },
                values: new object[,]
                {
                    { 1, "janbanan72@outlook.com", "Jan", "Banan" },
                    { 2, "shellstom@gmail.com", "Sara", "Hellström" },
                    { 3, "mvk@adel.se", "Margret", "von Kallsup" },
                    { 4, "feskegottanna@gbg.com", "Glenn", "Glennsson" },
                    { 5, "svenisvang@hotmail.com", "Sven", "Fransson" },
                    { 6, "famousj@gmail.com", "Johanna", "Stenström" }
                });

            migrationBuilder.InsertData(
                table: "BookLoans",
                columns: new[] { "BookLoanId", "BookId", "CustomerId", "DueDate", "LoanDate", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 7, 2, new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 5, 3, new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 6, 1, new DateTime(2022, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 3, 4, new DateTime(2022, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 2, 2, new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 6, 5, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 7, 1, new DateTime(2022, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 1, 5, new DateTime(2022, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 2, 3, new DateTime(2022, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 4, 4, new DateTime(2022, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 1, 2, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 7, 5, new DateTime(2022, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 1, 4, new DateTime(2022, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "AmountInLibrary",
                table: "Books");

            migrationBuilder.AlterColumn<string>(
                name: "CustomerLastName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AlterColumn<string>(
                name: "CustomerFirstName",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(25)",
                oldMaxLength: 25);

            migrationBuilder.AddColumn<bool>(
                name: "IsReturned",
                table: "BookLoans",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
