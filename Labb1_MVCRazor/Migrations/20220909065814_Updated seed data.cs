using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Labb1_MVCRazor.Migrations
{
    public partial class Updatedseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ImageURL",
                value: "/Images/sapiens.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ImageURL",
                value: "/Images/snabba-cash.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "ImageURL",
                value: "/Images/kungshjärta.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "ImageURL",
                value: "/Images/svart-historia.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "ImageURL",
                value: "/Images/paradis-city.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                column: "ImageURL",
                value: "/Images/stjärnfall.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                column: "ImageURL",
                value: "/Images/livet-efter-40--en-guide-för-män.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                column: "ImageURL",
                value: "/Images/svartfågel.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                column: "ImageURL",
                value: "~/Images/sapiens.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                column: "ImageURL",
                value: "~/Images/snabba-cash.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                column: "ImageURL",
                value: "~/Images/kungshjärta.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                column: "ImageURL",
                value: "~/Images/svart-historia.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                column: "ImageURL",
                value: "~/Images/paradis-city.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                column: "ImageURL",
                value: "~/Images/stjärnfall.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                column: "ImageURL",
                value: "~/Images/livet-efter-40--en-guide-för-män.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                column: "ImageURL",
                value: "~/Images/svartfågel.jpg");
        }
    }
}
