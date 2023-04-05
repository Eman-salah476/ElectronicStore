using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationDemo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edit3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("3c9f3c75-cfb0-4f4a-8fb4-fe6c9ebb4e34"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("4a750622-73ec-41ee-b77c-423b4e62910e"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6f5d5c6d-23ae-4091-a4fa-b9097d6bf96a"));

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CretaedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("5f1adae4-5d12-4e60-bedd-613128a5ff90"), "Mobile" },
                    { new Guid("6193b00a-31a2-4e28-a3ba-1de1be353296"), "Tablet" },
                    { new Guid("c6f4c36b-38c6-4fde-95bf-fadbf288332b"), "LabTop" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("5f1adae4-5d12-4e60-bedd-613128a5ff90"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6193b00a-31a2-4e28-a3ba-1de1be353296"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("c6f4c36b-38c6-4fde-95bf-fadbf288332b"));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("3c9f3c75-cfb0-4f4a-8fb4-fe6c9ebb4e34"), "LabTop" },
                    { new Guid("4a750622-73ec-41ee-b77c-423b4e62910e"), "Tablet" },
                    { new Guid("6f5d5c6d-23ae-4091-a4fa-b9097d6bf96a"), "Mobile" }
                });
        }
    }
}
