using Microsoft.EntityFrameworkCore;

namespace supply_chain_server.Models;

public class SupplyChainDBContext : DbContext
{
    public SupplyChainDBContext(DbContextOptions<SupplyChainDBContext> options)
        : base(options)
    {
    }

    public DbSet<Role> Roles { get; set; } = null!;
}