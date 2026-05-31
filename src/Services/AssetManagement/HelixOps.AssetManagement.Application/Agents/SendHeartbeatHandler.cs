using HelixOps.Contracts.Events;
using MediatR;

public class SendHeartbeatHandler : IRequestHandler<SendHeartbeatCommand>
{
    private readonly IAgentRepository _repo;
    private readonly IEventBus _bus;

    public SendHeartbeatHandler(
        IAgentRepository repo,
        IEventBus bus)
    {
        _repo = repo;
        _bus = bus;
    }

    public async Task Handle(SendHeartbeatCommand command, CancellationToken ct)
    {
        var agent = await _repo.Get(command.AgentId);

        if (agent == null)
            throw new Exception("Agent not found");

        if (agent.LastHeartbeatAt > DateTime.UtcNow.AddSeconds(-10))
            return;

        agent.RegisterHeartbeat();

        await _repo.Save(agent);

        await _bus.Publish(new AgentHeartbeatReceived(
            agent.Id,
            DateTime.UtcNow,
            "AssetManagement"
        ));
    }
}