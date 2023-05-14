using DemoEF_CodeFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoEF_CodeFirst
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions options) : base(options)
        {
        }

        System.Data.Entity.DbSet<Person> Employees { get; set; }
    }
}
