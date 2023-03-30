using Microsoft.EntityFrameworkCore;
using TodoApp.DataAccess.Mappings;
using TodoApp.Entities.Concrete;

namespace TodoApp.DataAccess.Context
{
    public class TodoContext : DbContext
    {

        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkMapping());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Work> Works { get; set; }
    }
}
