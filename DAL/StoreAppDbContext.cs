using Microsoft.EntityFrameworkCore;
using StoreApp.Models; 

public class StoreAppDbContext : DbContext
{
    public StoreAppDbContext(DbContextOptions<StoreAppDbContext> options)
        : base(options)
    {
    }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders{ get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Bağlantı dizesini burada da belirtebilirsiniz (alternatif olarak constructor'da)
         optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=MyStoreDb;User Id=postgres;Password=root");
    }
}