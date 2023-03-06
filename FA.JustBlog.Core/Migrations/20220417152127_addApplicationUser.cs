using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class addApplicationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UrlSlug",
                table: "Categories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 21, 26, 951, DateTimeKind.Local).AddTicks(1791), new DateTime(2022, 4, 17, 22, 21, 26, 951, DateTimeKind.Local).AddTicks(1777) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 21, 26, 951, DateTimeKind.Local).AddTicks(1794), new DateTime(2022, 4, 17, 22, 21, 26, 951, DateTimeKind.Local).AddTicks(1793) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 21, 26, 951, DateTimeKind.Local).AddTicks(1796), new DateTime(2022, 4, 17, 22, 21, 26, 951, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 21, 26, 951, DateTimeKind.Local).AddTicks(1798), new DateTime(2022, 4, 17, 22, 21, 26, 951, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 21, 26, 951, DateTimeKind.Local).AddTicks(1800), new DateTime(2022, 4, 17, 22, 21, 26, 951, DateTimeKind.Local).AddTicks(1799) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 22, 21, 26, 951, DateTimeKind.Local).AddTicks(1802), new DateTime(2022, 4, 17, 22, 21, 26, 951, DateTimeKind.Local).AddTicks(1801) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UrlSlug",
                table: "Categories",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1958), new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1947) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1961), new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1963), new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1963) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1965), new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1965) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1967), new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1966) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1969), new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1968) });
        }
    }
}
