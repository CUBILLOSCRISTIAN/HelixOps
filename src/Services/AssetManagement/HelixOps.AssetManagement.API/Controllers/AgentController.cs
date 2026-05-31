using Microsoft.AspNetCore.Mvc;

using MediatR;

[ApiController]
[Route("agents")]
public class AgentController : ControllerBase
{
    private readonly IMediator _mediator;

    public AgentController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("{id}/heartbeat")]
    public async Task<IActionResult> Heartbeat(Guid id)
    {
        await _mediator.Send(new SendHeartbeatCommand(id));
        return Ok();
    }
}