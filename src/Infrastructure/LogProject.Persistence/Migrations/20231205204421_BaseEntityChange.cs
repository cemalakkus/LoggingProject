using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CQRSProject.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class BaseEntityChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("083d0ee2-685b-4d52-8fae-c623c1f8e367"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("41917384-6a3b-4673-a40f-e20d00d507dd"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("91a3d69e-1dfa-4df9-9470-50fb4b29527d"));

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Product",
                newName: "Created");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Product",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "LastModified",
                table: "Product",
                type: "timestamp with time zone",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastModifiedBy",
                table: "Product",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("7f964f30-b07c-4755-975d-fc2b0b3bf65f"), new DateTime(2023, 12, 5, 23, 44, 20, 786, DateTimeKind.Local).AddTicks(7036), "0", null, "", "Pen", 10m, 100 },
                    { new Guid("d384bb8a-e078-491d-bf33-1f58334f5c8f"), new DateTime(2023, 12, 5, 23, 44, 20, 786, DateTimeKind.Local).AddTicks(7074), "0", null, "", "Book", 30m, 500 },
                    { new Guid("dc103cf3-12ab-4a17-99e0-9e888ed0d7fe"), new DateTime(2023, 12, 5, 23, 44, 20, 786, DateTimeKind.Local).AddTicks(7055), "0", null, "", "Paper A4", 4m, 200 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("7f964f30-b07c-4755-975d-fc2b0b3bf65f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d384bb8a-e078-491d-bf33-1f58334f5c8f"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dc103cf3-12ab-4a17-99e0-9e888ed0d7fe"));

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LastModified",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "LastModifiedBy",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Created",
                table: "Product",
                newName: "CreateDate");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CreateDate", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { new Guid("083d0ee2-685b-4d52-8fae-c623c1f8e367"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Book", 30m, 500 },
                    { new Guid("41917384-6a3b-4673-a40f-e20d00d507dd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Paper A4", 4m, 200 },
                    { new Guid("91a3d69e-1dfa-4df9-9470-50fb4b29527d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pen", 10m, 100 }
                });
        }
    }
}
