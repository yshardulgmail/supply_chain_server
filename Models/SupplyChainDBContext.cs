using Microsoft.EntityFrameworkCore;
namespace supply_chain_server.Models;

public class SupplyChainDBContext : DbContext
{
    public DbSet<Role> Roles { get; set; } = null!;
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Customer> Customers { get; set; } = null!;
    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Status> Statuses { get; set; } = null!;
    public DbSet<Order> Orders { get; set; } = null!;

    public DbSet<UserRole> UserRoles { get; set; } = null!;

    public SupplyChainDBContext(DbContextOptions<SupplyChainDBContext> options)
        : base(options)
    {
    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<UserRole>(builder =>
    //     {
    //         builder.HasNoKey();
    //         builder.ToTable("UserRoles");
    //     });
    // }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {    
    //     modelBuilder.Entity<UserRole>()
    //         .HasMany(c => c.User).WithMany(i => i.Role)
    //         .Map(t => t.MapLeftKey("User_Id")
    //             .MapRightKey("Role_Id")
    //             .ToTable("UserRoles"));
    // }
}