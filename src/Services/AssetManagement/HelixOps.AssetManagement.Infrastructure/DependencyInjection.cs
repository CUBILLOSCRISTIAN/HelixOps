using HelixOps.AssetManagement.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RabbitMQ.Client;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        string connectionString)
    {
        services.AddDbContext<HelixOpsDbContext>(opt =>
            opt.UseNpgsql(connectionString));

        services.AddScoped<IAgentRepository, AgentRepository>();
        services.AddScoped<IEventBus, RabbitMqEventBus>();

        services.AddSingleton<IConnection>(sp =>
        {
            var factory = new ConnectionFactory
            {
                HostName = "localhost",
                DispatchConsumersAsync = true,
                AutomaticRecoveryEnabled = true
            };

            return factory.CreateConnection();
        });

        return services;
    }
}
