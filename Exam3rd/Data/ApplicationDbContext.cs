using Exam3rd.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Exam3rd.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categoriesss { get; set; }
        public DbSet<Product> Productss { get; set; }
    
    }
}
