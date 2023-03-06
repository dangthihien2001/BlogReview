using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class updateCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1958), new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1947), 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1961), new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1961), 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1963), new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1963), 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Modified", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1965), new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1965), 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Modified", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1967), new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1966), 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Modified", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1969), new DateTime(2022, 4, 17, 18, 50, 2, 457, DateTimeKind.Local).AddTicks(1968), 0, 0, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Modified", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7157), new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7149), null, null, null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Modified", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7160), new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7159), null, null, null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Modified", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7161), new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7161), null, null, null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Modified", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7163), new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7163), null, null, null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Modified", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7165), new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7165), null, null, null });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Modified", "PostedOn", "RateCount", "TotalRate", "ViewCount" },
                values: new object[] { new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7167), new DateTime(2022, 4, 17, 17, 42, 29, 328, DateTimeKind.Local).AddTicks(7167), null, null, null });
        }
    }
}
