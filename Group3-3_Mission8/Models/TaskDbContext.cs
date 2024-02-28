using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Group3_3_Mission8.Models
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) : base(options) { }

        public DbSet<Task> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
