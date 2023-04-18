using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApplicationDemo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class edit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("13d8be41-0c0d-41fa-95c3-6c625978cea1"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("50c3d300-5b8e-424e-b31e-49128b719dfb"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("822a3a81-448c-4977-bac8-937ef816d63b"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("13d8be41-0c0d-41fa-95c3-6c625978cea1"), "Mobile" },
                    { new Guid("50c3d300-5b8e-424e-b31e-49128b719dfb"), "LabTop" },
                    { new Guid("822a3a81-448c-4977-bac8-937ef816d63b"), "Tablet" }
                });
        }
    }
}
