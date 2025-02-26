using Microsoft.EntityFrameworkCore;
using Product.EF.Infrastructure.EntityConfigurations;
using Product.EF.Models;

namespace Product.EF.Infrastructure
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options) { }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Models.Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
