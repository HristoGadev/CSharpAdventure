
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Forum.Data.Models
{
    public class User
    {
        public User()
        {
          
        }
        public User(string username, string password)

        {
            this.Username = username;
            this.Password = password;
        }
        public int Id { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }
        public ICollection<Reply> Replies { get; set; } = new List<Reply>();

        public ICollection<Post> Posts { get; set; } = new List<Post>();


    }
}
