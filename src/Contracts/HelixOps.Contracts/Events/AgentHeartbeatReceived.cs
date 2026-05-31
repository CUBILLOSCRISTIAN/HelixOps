namespace HelixOps.Contracts.Events;

public record AgentHeartbeatReceived(
    Guid AgentId,
    DateTime OccurredAt,
    string Source
);