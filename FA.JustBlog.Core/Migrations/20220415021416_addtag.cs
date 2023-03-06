using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class addtag : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PostTagMap",
                columns: new[] { "PostId", "TagId" },
                values: new object[] { 1, 2 });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTagMap",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 14, 10, 57, 9, 817, DateTimeKind.Local).AddTicks(7681), new DateTime(2022, 4, 14, 10, 57, 9, 817, DateTimeKind.Local).AddTicks(7672) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 14, 10, 57, 9, 817, DateTimeKind.Local).AddTicks(7683), new DateTime(2022, 4, 14, 10, 57, 9, 817, DateTimeKind.Local).AddTicks(7683) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 14, 10, 57, 9, 817, DateTimeKind.Local).AddTicks(7685), new DateTime(2022, 4, 14, 10, 57, 9, 817, DateTimeKind.Local).AddTicks(7685) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 14, 10, 57, 9, 817, DateTimeKind.Local).AddTicks(7687), new DateTime(2022, 4, 14, 10, 57, 9, 817, DateTimeKind.Local).AddTicks(7687) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 14, 10, 57, 9, 817, DateTimeKind.Local).AddTicks(7689), new DateTime(2022, 4, 14, 10, 57, 9, 817, DateTimeKind.Local).AddTicks(7689) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Modified", "PostedOn" },
                values: new object[] { new DateTime(2022, 4, 14, 10, 57, 9, 817, DateTimeKind.Local).AddTicks(7691), new DateTime(2022, 4, 14, 10, 57, 9, 817, DateTimeKind.Local).AddTicks(7691) });
        }
    }
}
