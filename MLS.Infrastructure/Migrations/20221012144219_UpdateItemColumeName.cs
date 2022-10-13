using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MLS.Infrastructure.Migrations
{
    public partial class UpdateItemColumeName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Priority",
                table: "TodoItem");

            migrationBuilder.DropColumn(
                name: "Reminder",
                table: "TodoItem");

            migrationBuilder.AddColumn<long>(
                name: "ItemId",
                table: "TodoItem",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemId",
                table: "TodoItem");

            migrationBuilder.AddColumn<int>(
                name: "Priority",
                table: "TodoItem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Reminder",
                table: "TodoItem",
                type: "datetime2",
                nullable: true);
        }
    }
}
