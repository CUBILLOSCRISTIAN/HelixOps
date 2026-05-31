using Microsoft.EntityFrameworkCore;
using HelixOps.AssetManagement.Domain.Agents;
using HelixOps.AssetManagement.Domain.Devices;

namespace HelixOps.AssetManagement.Infrastructure.Persistence;

public class HelixOpsDbContext : DbContext
{
    public HelixOpsDbContext(DbContextOptions<HelixOpsDbContext> options)
        : base(options)
    {
    }

    public DbSet<Device> Devices => Set<Device>();
    public DbSet<ManagementAgent> Agents => Set<ManagementAgent>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(HelixOpsDbContext).Assembly);
    }
}