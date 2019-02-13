using System.Collections.Generic;

namespace Forum.Data.Models
{
   public class Post
    {
        public Post()
        {

        }
        public Post(string title, string content, Category category, User author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
            this.Category = category;
        }

        public Post(string title, string content, int authorId,  int categoryId)
        {
            this.Title = title;
            this.Content = content;
            this.AuthorId = authorId;
            this.CategoryId = categoryId;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int AuthorId { get; set; }
        public User Author { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<Reply> Replies { get; set; }
    }
}
