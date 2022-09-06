using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb1_MVCRazor.Migrations
{
    public partial class MadeBookItemEntityforspecificbooksChangedseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookLoans_Books_BookId",
                table: "BookLoans");

            migrationBuilder.RenameColumn(
                name: "BookId",
                table: "BookLoans",
                newName: "BookItemId");

            migrationBuilder.RenameIndex(
                name: "IX_BookLoans_BookId",
                table: "BookLoans",
                newName: "IX_BookLoans_BookItemId");

            migrationBuilder.CreateTable(
                name: "BookItems",
                columns: table => new
                {
                    BookItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookItems", x => x.BookItemId);
                    table.ForeignKey(
                        name: "FK_BookItems_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BookItems",
                columns: new[] { "BookItemId", "BookId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 },
                    { 4, 2 },
                    { 5, 2 },
                    { 6, 2 },
                    { 7, 2 },
                    { 8, 3 },
                    { 9, 3 },
                    { 10, 3 },
                    { 11, 4 },
                    { 12, 5 },
                    { 13, 5 },
                    { 14, 6 },
                    { 15, 6 },
                    { 16, 7 },
                    { 17, 7 },
                    { 18, 7 },
                    { 19, 8 },
                    { 20, 8 }
                });

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 1,
                column: "BookItemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 2,
                column: "BookItemId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 3,
                column: "BookItemId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 4,
                column: "BookItemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 5,
                column: "BookItemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 6,
                column: "BookItemId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 7,
                column: "BookItemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 8,
                column: "BookItemId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 9,
                column: "BookItemId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 10,
                column: "BookItemId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 11,
                column: "BookItemId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 13,
                column: "BookItemId",
                value: 3);

            migrationBuilder.CreateIndex(
                name: "IX_BookItems_BookId",
                table: "BookItems",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookLoans_BookItems_BookItemId",
                table: "BookLoans",
                column: "BookItemId",
                principalTable: "BookItems",
                principalColumn: "BookItemId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookLoans_BookItems_BookItemId",
                table: "BookLoans");

            migrationBuilder.DropTable(
                name: "BookItems");

            migrationBuilder.RenameColumn(
                name: "BookItemId",
                table: "BookLoans",
                newName: "BookId");

            migrationBuilder.RenameIndex(
                name: "IX_BookLoans_BookItemId",
                table: "BookLoans",
                newName: "IX_BookLoans_BookId");

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 1,
                column: "BookId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 2,
                column: "BookId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 3,
                column: "BookId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 4,
                column: "BookId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 5,
                column: "BookId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 6,
                column: "BookId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 7,
                column: "BookId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 8,
                column: "BookId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 9,
                column: "BookId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 10,
                column: "BookId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 11,
                column: "BookId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "BookLoans",
                keyColumn: "BookLoanId",
                keyValue: 13,
                column: "BookId",
                value: 1);

            migrationBuilder.AddForeignKey(
                name: "FK_BookLoans_Books_BookId",
                table: "BookLoans",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
