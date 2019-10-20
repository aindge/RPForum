using Microsoft.EntityFrameworkCore;
using RpForum.Models;

namespace RpForum.Data
{
    public class RpContext : DbContext
    {
        public RpContext(DbContextOptions<RpContext> options)
            : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Thread> Threads { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}