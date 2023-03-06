using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class addAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 23, 31, 21, 885, DateTimeKind.Local).AddTicks(1597), new DateTime(2022, 4, 17, 23, 31, 21, 885, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 23, 31, 21, 885, DateTimeKind.Local).AddTicks(1599), new DateTime(2022, 4, 17, 23, 31, 21, 885, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 23, 31, 21, 885, DateTimeKind.Local).AddTicks(1601), new DateTime(2022, 4, 17, 23, 31, 21, 885, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 23, 31, 21, 885, DateTimeKind.Local).AddTicks(1603), new DateTime(2022, 4, 17, 23, 31, 21, 885, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 23, 31, 21, 885, DateTimeKind.Local).AddTicks(1630), new DateTime(2022, 4, 17, 23, 31, 21, 885, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 23, 31, 21, 885, DateTimeKind.Local).AddTicks(1632), new DateTime(2022, 4, 17, 23, 31, 21, 885, DateTimeKind.Local).AddTicks(1631) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 23, 5, 11, 83, DateTimeKind.Local).AddTicks(6410), new DateTime(2022, 4, 17, 23, 5, 11, 83, DateTimeKind.Local).AddTicks(6395) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 23, 5, 11, 83, DateTimeKind.Local).AddTicks(6416), new DateTime(2022, 4, 17, 23, 5, 11, 83, DateTimeKind.Local).AddTicks(6414) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 23, 5, 11, 83, DateTimeKind.Local).AddTicks(6420), new DateTime(2022, 4, 17, 23, 5, 11, 83, DateTimeKind.Local).AddTicks(6419) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 23, 5, 11, 83, DateTimeKind.Local).AddTicks(6425), new DateTime(2022, 4, 17, 23, 5, 11, 83, DateTimeKind.Local).AddTicks(6424) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 23, 5, 11, 83, DateTimeKind.Local).AddTicks(6430), new DateTime(2022, 4, 17, 23, 5, 11, 83, DateTimeKind.Local).AddTicks(6429) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 17, 23, 5, 11, 83, DateTimeKind.Local).AddTicks(6434), new DateTime(2022, 4, 17, 23, 5, 11, 83, DateTimeKind.Local).AddTicks(6433) });
        }
    }
}
