namespace HelixOps.AssetManagement.Domain.Agents;

public class ManagementAgent
{
    public Guid Id { get; private set; }
    public Guid DeviceId { get; private set; }

    public string Version { get; private set; } = "0.0.0";
    public DateTime LastHeartbeatAt { get; private set; }

    private ManagementAgent() { }

    public ManagementAgent(Guid deviceId)
    {
        Id = Guid.NewGuid();
        DeviceId = deviceId;
        LastHeartbeatAt = DateTime.UtcNow;
    }

    public void RegisterHeartbeat()
    {
        LastHeartbeatAt = DateTime.UtcNow;
    }
}