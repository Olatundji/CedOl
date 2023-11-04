using CedOl.Net.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace CedOl.Net.Data
{
    public class CedOlDbContext : DbContext
    {
        public CedOlDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
