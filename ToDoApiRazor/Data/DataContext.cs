using EenVoudigeToDoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace ToDoApiRazor.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Board> Boards { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ToDo> ToDos { get; set; }

    }
}
