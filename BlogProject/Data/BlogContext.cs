using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogProject.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogProject
{
    public class BlogContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<PostTag> PostTags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=BlogProject;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostTag>().HasKey(pt => new { pt.PostId, pt.TagId });

            Post postTestOne = new Post()
            {
                Title = "BlaBla",
                Body = "My new dog rocks.",
                Author = "Jane D",
                PostId = 1,
                CategoryId = 1
            };
            Post postTestTwo = new Post()
            {
                Title = "Loving My New Dog!",
                Body = "My new dog rocks.",
                Author = "Jane D",
                PostId = 2,
                CategoryId = 2
            };

            Tag testTagOne = new Tag()
            {
                Name = "Tag A",
                TagId = 1
            };
            Tag testTagTwo = new Tag()
            {
                Name = "Tag B",
                TagId = 2
            };

            postTestOne.PostTags = new List<PostTag>();
            {
                new PostTag()
                {
                    Post = postTestOne,
                    Tag = testTagOne
                };
            }
            postTestTwo.PostTags = new List<PostTag>();
            {
                new PostTag()
                {
                    Post = postTestTwo,
                    Tag = testTagTwo
                };
            }

            modelBuilder.Entity<Post>().HasData
                (
                    postTestOne,
                    postTestTwo
                );

            modelBuilder.Entity<Category>().HasData
                (
                    new Category(1,"Stuff A"),
                    new Category(2,"Stuff B")
                );

            modelBuilder.Entity<Tag>().HasData
                (
                    testTagOne,
                    testTagTwo
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}
