using BlazorECommerce.Configurations;
using Microsoft.EntityFrameworkCore;

namespace BlazorECommerce.Models;

public class ECommerceContext(DbContextOptions<ECommerceContext> options) : DbContext(options)
{
    public DbSet<Categories> Categories { get; set; } = default!;
    public DbSet<Products> Products { get; set; } = default!;
    public DbSet<Orders> Orders { get; set; } = default!;
    public DbSet<Users> Users { get; set; } = default!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductsConfig());
        modelBuilder.ApplyConfiguration(new CategoriesConfig());
        modelBuilder.ApplyConfiguration(new UsersConfig());
        modelBuilder.ApplyConfiguration(new OrdersConfig());
    }
}