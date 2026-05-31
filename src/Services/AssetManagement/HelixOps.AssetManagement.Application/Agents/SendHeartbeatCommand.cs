using MediatR;

public record SendHeartbeatCommand(Guid AgentId)
    : IRequest;