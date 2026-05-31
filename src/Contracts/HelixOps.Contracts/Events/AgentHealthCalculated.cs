namespace HelixOps.Contracts.Events;

public record AgentHealthCalculated(
    Guid AgentId,
    string Health, // Healthy | Degraded | Offline
    DateTime OccurredAt
);