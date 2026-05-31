using HelixOps.AssetManagement.Domain.Agents;

public interface IAgentRepository
{
    Task<ManagementAgent?> Get(Guid id);
    Task Save(ManagementAgent agent);
}