using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class DeleteCascade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7157), new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7160), new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7161), new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7163), new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7163) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7165), new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7167), new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7167) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Best");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Samsung");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 15, 9, 14, 16, 577, DateTimeKind.Local).AddTicks(3658), new DateTime(2022, 4, 15, 9, 14, 16, 577, DateTimeKind.Local).AddTicks(3651) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 15, 9, 14, 16, 577, DateTimeKind.Local).AddTicks(3660), new DateTime(2022, 4, 15, 9, 14, 16, 577, DateTimeKind.Local).AddTicks(3659) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 15, 9, 14, 16, 577, DateTimeKind.Local).AddTicks(3662), new DateTime(2022, 4, 15, 9, 14, 16, 577, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 15, 9, 14, 16, 577, DateTimeKind.Local).AddTicks(3664), new DateTime(2022, 4, 15, 9, 14, 16, 577, DateTimeKind.Local).AddTicks(3663) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 15, 9, 14, 16, 577, DateTimeKind.Local).AddTicks(3665), new DateTime(2022, 4, 15, 9, 14, 16, 577, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 15, 9, 14, 16, 577, DateTimeKind.Local).AddTicks(3667), new DateTime(2022, 4, 15, 9, 14, 16, 577, DateTimeKind.Local).AddTicks(3667) });

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Best true wireless");

            migrationBuilder.UpdateData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "The best Samsung");
        }
    }
}
