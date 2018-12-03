using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore1.Migrations
{
    public partial class BasketFunction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Book",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_ApplicationUserId",
                table: "Book",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_AspNetUsers_ApplicationUserId",
                table: "Book",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_AspNetUsers_ApplicationUserId",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_ApplicationUserId",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Book");
        }
    }
}
