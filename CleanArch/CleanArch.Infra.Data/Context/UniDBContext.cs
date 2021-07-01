using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    public class UniDbContext : DbContext
    {
        public UniDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Course> Courses { get; set; }
    }
}