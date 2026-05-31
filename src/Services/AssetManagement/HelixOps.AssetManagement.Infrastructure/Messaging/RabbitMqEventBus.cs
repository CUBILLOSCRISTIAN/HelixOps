using System.Text;
using System.Text.Json;
using RabbitMQ.Client;

using HelixOps.Contracts.Events;

public class RabbitMqEventBus : IEventBus
{
    private readonly IConnection _connection;

    public RabbitMqEventBus(IConnection connection)
    {
        _connection = connection;
    }

    public async Task Publish<T>(T @event)
    {
        var eventName = typeof(T).Name;
        var body = Encoding.UTF8.GetBytes(JsonSerializer.Serialize(@event));

        using var channel = _connection.CreateModel();

        var attempts = 3;

        while (attempts-- > 0)
        {
            try
            {
                channel.QueueDeclare(eventName, true, false, false);

                channel.BasicPublish(
                    exchange: "",
                    routingKey: eventName,
                    body: body
                    );
                return;
            }
            catch
            {
                if (attempts == 0)
                    throw;

                await Task.Delay(200);
            }
        }
    }
}