using Microsoft.EntityFrameworkCore;

namespace WebApiBasic.Models
{
    public class AppDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            builder.UseSqlServer(configuration.GetConnectionString("BasicAPIDb"));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");
                entity.HasKey(p => p.productId);
                entity.Property(p => p.productDescription).IsRequired(false);
            });
        }
    }
}
