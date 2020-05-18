using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityStart
{
    // Program is usING 2 public Classes AND 1 context
    // Context is gathering the classes 
    public class BloggingContext : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=blogging.db");
    }
    // Blog Class setting the availibity of Class and it's attributes to be use in the scope of project
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        // Post Attributes listing Post Class attributes
        public List<Post> Posts { get; } = new List<Post>();
    }

    // Post Class 
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        // Blog Id foreign key
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}