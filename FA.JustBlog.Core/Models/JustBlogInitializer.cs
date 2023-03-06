using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Core.Models
{
    public static class JustBlogInitializer
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Category category = new Category()
            {
                Id = 1,
                Name = "Apple",
                Description = "blog about Apple",
                UrlSlug = "blog-about-Apple"
            };
            Category category1 = new Category()
            {
                Id = 2,
                Name = "SamSung",
                Description = "blog about SamSung",
                UrlSlug = "blog-about-SamSung"
            };

            modelBuilder.Entity<Category>().HasData(category, category1);
            modelBuilder.Entity<Post>().HasData(
                 new Post()
                 {
                     Id = 1,
                     Title = "Best true wireless earbuds for 2021",
                     ShortDescription = "True wireless earbuds are all the rage. Here are the top wire-free models you can buy right now",
                     PostContent = "The market for a true wireless earbud has exploded over the last few years. Sure, Apple's AirPods and AirPods Pro remain best sellers in the category, but plenty of excellent competitors are available, several of which are new for 2021 and offer superior audio quality, battery life and performance. And some of these buds are more suited for Android users who can't take advantage of the AirPods' and AirPods Pro's Apple-only features such as hands-free Siri and spatial audio with head-tracking, in the case of the AirPods Pro.",
                     Published = true,
                     UrlSlug = "Apple1",
                     PostedOn = DateTime.Now,
                     Modified = DateTime.Now,
                     CategoryId = 1
                 },
                    new Post()
                    {
                        Id = 2,
                        Title = "Best fitness trackers for 2021",
                        ShortDescription = "Fitbit, Apple and more: Five options to help kick your fitness routine into high gear.",
                        PostContent = "A fitness tracker can be a great way to help you get -- or stay -- in shape without needing an all-out smartwatch. A fitness tracker holds you accountable for your physical activity with health and fitness features, such as sleep tracking, heart-rate monitoring, connected GPS and other insights into your daily activities. Your fitness tracking data is then shared with an app to give you a better view of your overall fitness.",
                        Published = true,
                        UrlSlug = "Apple2",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1

                    },
                    new Post()
                    {
                        Id = 3,
                        Title = "Best AirPods deals before Black",
                        ShortDescription = "Friday: New AirPods Pro hit $190, $89 AirPods 2 coming soon",
                        PostContent = "AirPods are once again at the top of a lot of holiday wishlists, but the landscape for Apple headphones has changed drastically over the past few weeks, as we approach Black Friday. Here's what's new and notable in the world of AirPods",
                        Published = false,
                        UrlSlug = "Apple3",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 1
                    },
                     new Post()
                     {
                         Id = 4,
                         Title = "Samsung Galaxy S22 Ultra review",
                         ShortDescription = "The Samsung Galaxy S22 Ultra delivers a built-in S Pen, brighter display and lots of camera upgrades in a sleek design",
                         PostContent = "The Samsung Galaxy S22 Ultra is an amped-up Galaxy Note with a faster S Pen built in, lots of camera improvements, a brighter display and faster charging. This is a stellar phone overall, but it's also pretty pricey and the battery life could be better.",
                         Published = true,
                         UrlSlug = "Samsung-Galaxy-S22-Ultra-review",
                         PostedOn = DateTime.Now,
                         Modified = DateTime.Now,
                         CategoryId = 2
                     },
                    new Post()
                    {
                        Id = 5,
                        Title = "Samsung Galaxy S22 review",
                        ShortDescription = "Samsung doesn't shake things up with the Galaxy S22, but it doesn't really need to",
                        PostContent = "The Galaxy S22 features modest, if not earth-shattering improvements, from last year's Galaxy S21. It's the Samsung phone to get if you want premium features for less than $1,000.",
                        Published = false,
                        UrlSlug = "Samsung-Galaxy-S22-review",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 2
                    },
                    new Post()
                    {
                        Id = 6,
                        Title = "The best Samsung watch in 2022",
                        ShortDescription = "Here’s how to figure out which is the best Samsung watch for you",
                        PostContent = "What is the best Samsung watch? The answer depends on what you’re looking for out of a smartwatch for Samsung users. Whether you’re looking for a device for fitness tracking, an extension of your smartphone or something that can save your life in some emergencies, there’s a Galaxy Watch for you.",
                        Published = true,
                        UrlSlug = "The-best-Samsung-watch-in-2022",
                        PostedOn = DateTime.Now,
                        Modified = DateTime.Now,
                        CategoryId = 2
                    }
                );
            modelBuilder.Entity<Tag>().HasData(
                    new Tag()
                    {
                        Id = 1,
                        Name = "Best"

                    },
                    new Tag()
                    {
                        Id = 2,
                        Name = "Samsung"

                    }
                );
            modelBuilder.Entity<PostTagMap>().HasData(
                new PostTagMap() { PostId = 1, TagId = 1 },
                new PostTagMap() { PostId = 4, TagId = 2 },
                new PostTagMap() { PostId = 6, TagId = 2 },
                new PostTagMap() { PostId = 1, TagId = 2 });

        }
    }
}