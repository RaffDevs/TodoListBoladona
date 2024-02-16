using Microsoft.EntityFrameworkCore;
using TodoListBoladona.Entities;

namespace TodoListBoladona.Database
{

    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Category> Category { get; set; }
        public DbSet<Todo> Todo { get; set; }

    }
}
