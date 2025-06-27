using FirstMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        {
        }

        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<ChatMessage> ChatMessages { get; set; }

    }
}
