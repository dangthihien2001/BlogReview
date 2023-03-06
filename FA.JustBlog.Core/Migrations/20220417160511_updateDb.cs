using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class updateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
