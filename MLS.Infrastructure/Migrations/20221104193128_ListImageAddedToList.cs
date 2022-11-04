using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MLS.Infrastructure.Migrations
{
    public partial class ListImageAddedToList : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListImage",
                table: "TodoItems");

            migrationBuilder.AddColumn<string>(
                name: "ListImage",
                table: "TodoLists",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListImage",
                table: "TodoLists");

            migrationBuilder.AddColumn<string>(
                name: "ListImage",
                table: "TodoItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
