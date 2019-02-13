
using Microsoft.EntityFrameworkCore;

namespace Forum.Data.Models
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext()
        {
        }

        public ForumDbContext(DbContextOptions options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<Reply> Reply { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Posts)
                .WithOne(c => c.Category)
                .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<Post>()
                .HasMany(p => p.Replies)
                .WithOne(p => p.Post)
                .HasForeignKey(p => p.PostId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(p => p.Posts)
                .WithOne(p => p.Author)
                .HasForeignKey(p=> p.AuthorId);

            modelBuilder.Entity<User>()
                .HasMany(r => r.Replies)
                .WithOne(r => r.Author)
                .HasForeignKey(r => r.AuthorId);
        }
    }
}
