using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MLS.Infrastructure.Migrations
{
    public partial class ListImageAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListId",
                table: "TodoLists");

            migrationBuilder.AddColumn<string>(
                name: "ListImage",
                table: "TodoItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListImage",
                table: "TodoItems");

            migrationBuilder.AddColumn<int>(
                name: "ListId",
                table: "TodoLists",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
