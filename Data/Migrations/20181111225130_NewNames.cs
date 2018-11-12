using Microsoft.EntityFrameworkCore.Migrations;

namespace Bookstore.Data.Migrations
{
    public partial class NewNames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Book",
                newName: "CoverType");

            migrationBuilder.RenameColumn(
                name: "Pulication_year",
                table: "Book",
                newName: "PublicationYear");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublicationYear",
                table: "Book",
                newName: "Pulication_year");

            migrationBuilder.RenameColumn(
                name: "CoverType",
                table: "Book",
                newName: "Type");
        }
    }
}
