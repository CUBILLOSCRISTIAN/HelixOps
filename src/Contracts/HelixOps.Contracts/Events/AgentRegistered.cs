namespace HelixOps.Contracts.Events;

public record AgentRegistered(
    Guid AgentId,
    Guid DeviceId,
    DateTime OccurredAt
);