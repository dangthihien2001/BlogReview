using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FA.JustBlog.Core.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { 1, "blog about Apple", "Apple", "blog-about-Apple" },
                    { 2, "blog about SamSung", "SamSung", "blog-about-SamSung" }
                });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "Count", "Description", "Name", "UrlSlug" },
                values: new object[,]
                {
                    { 1, null, null, "Best true wireless", null },
                    { 2, null, null, "The best Samsung", null }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CategoryId", "Modified", "PostContent", "PostedOn", "Published", "RateCount", "ShortDescription", "Title", "TotalRate", "UrlSlug", "ViewCount" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 4, 12, 13, 15, 5, 875, DateTimeKind.Local).AddTicks(5913), "The market for a true wireless earbud has exploded over the last few years. Sure, Apple's AirPods and AirPods Pro remain best sellers in the category, but plenty of excellent competitors are available, several of which are new for 2021 and offer superior audio quality, battery life and performance. And some of these buds are more suited for Android users who can't take advantage of the AirPods' and AirPods Pro's Apple-only features such as hands-free Siri and spatial audio with head-tracking, in the case of the AirPods Pro.", new DateTime(2022, 4, 12, 13, 15, 5, 875, DateTimeKind.Local).AddTicks(5904), true, null, "True wireless earbuds are all the rage. Here are the top wire-free models you can buy right now", "Best true wireless earbuds for 2021", null, "Apple1", null },
                    { 2, 1, new DateTime(2022, 4, 12, 13, 15, 5, 875, DateTimeKind.Local).AddTicks(5916), "A fitness tracker can be a great way to help you get -- or stay -- in shape without needing an all-out smartwatch. A fitness tracker holds you accountable for your physical activity with health and fitness features, such as sleep tracking, heart-rate monitoring, connected GPS and other insights into your daily activities. Your fitness tracking data is then shared with an app to give you a better view of your overall fitness.", new DateTime(2022, 4, 12, 13, 15, 5, 875, DateTimeKind.Local).AddTicks(5915), true, null, "Fitbit, Apple and more: Five options to help kick your fitness routine into high gear.", "Best fitness trackers for 2021", null, "Apple2", null },
                    { 3, 1, new DateTime(2022, 4, 12, 13, 15, 5, 875, DateTimeKind.Local).AddTicks(5917), "AirPods are once again at the top of a lot of holiday wishlists, but the landscape for Apple headphones has changed drastically over the past few weeks, as we approach Black Friday. Here's what's new and notable in the world of AirPods", new DateTime(2022, 4, 12, 13, 15, 5, 875, DateTimeKind.Local).AddTicks(5917), false, null, "Friday: New AirPods Pro hit $190, $89 AirPods 2 coming soon", "Best AirPods deals before Black", null, "Apple3", null },
                    { 4, 2, new DateTime(2022, 4, 12, 13, 15, 5, 875, DateTimeKind.Local).AddTicks(5919), "The Samsung Galaxy S22 Ultra is an amped-up Galaxy Note with a faster S Pen built in, lots of camera improvements, a brighter display and faster charging. This is a stellar phone overall, but it's also pretty pricey and the battery life could be better.", new DateTime(2022, 4, 12, 13, 15, 5, 875, DateTimeKind.Local).AddTicks(5919), true, null, "The Samsung Galaxy S22 Ultra delivers a built-in S Pen, brighter display and lots of camera upgrades in a sleek design", "Samsung Galaxy S22 Ultra review", null, "Samsung-Galaxy-S22-Ultra-review", null },
                    { 5, 2, new DateTime(2022, 4, 12, 13, 15, 5, 875, DateTimeKind.Local).AddTicks(5921), "The Galaxy S22 features modest, if not earth-shattering improvements, from last year's Galaxy S21. It's the Samsung phone to get if you want premium features for less than $1,000.", new DateTime(2022, 4, 12, 13, 15, 5, 875, DateTimeKind.Local).AddTicks(5921), false, null, "Samsung doesn't shake things up with the Galaxy S22, but it doesn't really need to", "Samsung Galaxy S22 review", null, "Samsung-Galaxy-S22-review", null },
                    { 6, 2, new DateTime(2022, 4, 12, 13, 15, 5, 875, DateTimeKind.Local).AddTicks(5923), "What is the best Samsung watch? The answer depends on what you’re looking for out of a smartwatch for Samsung users. Whether you’re looking for a device for fitness tracking, an extension of your smartphone or something that can save your life in some emergencies, there’s a Galaxy Watch for you.", new DateTime(2022, 4, 12, 13, 15, 5, 875, DateTimeKind.Local).AddTicks(5923), true, null, "Here’s how to figure out which is the best Samsung watch for you", "The best Samsung watch in 2022", null, "The-best-Samsung-watch-in-2022", null }
                });

            migrationBuilder.InsertData(
                table: "PostTagMap",
                columns: new[] { "PostId", "TagId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "PostTagMap",
                columns: new[] { "PostId", "TagId" },
                values: new object[] { 4, 2 });

            migrationBuilder.InsertData(
                table: "PostTagMap",
                columns: new[] { "PostId", "TagId" },
                values: new object[] { 6, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PostTagMap",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "PostTagMap",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 4, 2 });

            migrationBuilder.DeleteData(
                table: "PostTagMap",
                keyColumns: new[] { "PostId", "TagId" },
                keyValues: new object[] { 6, 2 });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tags",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
