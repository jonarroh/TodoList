using Microsoft.EntityFrameworkCore;

namespace TodoList.Models
{
    public class Context: DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
          
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
