using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationDemo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edit2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("12ea27f0-52bd-4903-9a2d-bd0f3c42030a"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("29f5c519-a5a9-428d-a5a2-9695418751b2"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("7d4496ad-b991-4352-b03b-922c30cbdaed"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("12ea27f0-52bd-4903-9a2d-bd0f3c42030a"), "Tablet" },
                    { new Guid("29f5c519-a5a9-428d-a5a2-9695418751b2"), "LabTop" },
                    { new Guid("7d4496ad-b991-4352-b03b-922c30cbdaed"), "Mobile" }
                });
        }
    }
}
