using System;
using System.Linq;
using Forum.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Forum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var context = new ForumDbContext();
            ResetDataBase(context);

            var categories = context.Category
                .Include(c => c.Posts)
                .ThenInclude(p => p.Author)
                .Include(p => p.Posts)
                .ThenInclude(p => p.Replies)
                .ThenInclude(p => p.Author)
                .ToArray();

            foreach (var category in categories)
            {
                Console.WriteLine($"In {category.Name} hat ({category.Posts.Count}) posts");

                foreach (var post in category.Posts)
                {
                    Console.WriteLine($"--{post.Title} : {post.Content}");
                    Console.WriteLine($"Author: {post.Author.Username}");

                    foreach (var reply in post.Replies)
                    {
                        Console.WriteLine($"---- Reply from: {reply.Author.Username}");
                        Console.WriteLine($"{reply.Content}");
                    }
                }
            }
                

        }

        private static void ResetDataBase(ForumDbContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.Migrate();

            Seed(context);
        }

        private static void Seed(ForumDbContext context)
        {
            var users = new[]
            {
                new User("gosho", "123"),
                new User("sasho", "453"),
                new User("ivan", "475"),
                new User("stamat", "123")
            };

            context.User.AddRange(users);


            var categories = new[]
            {
                new Category("C#"),
                new Category("Python"),
                new Category("SoftUni"),
                new Category("Java")
            };
            context.Category.AddRange(categories);
            var posts = new[]
            {
                new Post("C# rulz","OOP",categories[0],users[0]),
                new Post("Python","Machines",categories[2],users[1]),
                new Post("SoftUni","Not bad",categories[1],users[2]),
                new Post("Java","OOP 2",categories[0],users[1])
            };


            context.Post.AddRange(posts);

            var replies = new[]
            {
                new Reply("Yes, I am agreed",posts[1],users[0]),
                new Reply("Nope", posts[2], users[1])
            };
            context.Reply.AddRange(replies);

            context.SaveChanges();
        }
    }
}
