using HelixOps.AssetManagement.Domain.Agents;
using HelixOps.AssetManagement.Infrastructure.Persistence;

public class AgentRepository : IAgentRepository
{
    private readonly HelixOpsDbContext _db;

    public AgentRepository(HelixOpsDbContext db)
    {
        _db = db;
    }

    public async Task<ManagementAgent?> Get(Guid id)
    {
        return await _db.Agents.FindAsync(id);
    }

    public async Task Save(ManagementAgent agent)
    {
        _db.Agents.Update(agent);
        await _db.SaveChangesAsync();
    }


}