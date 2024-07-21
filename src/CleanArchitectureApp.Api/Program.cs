using CleanArchitectureApp.Application.Extensions;
using CleanArchitectureApp.Infrastructure.Extensions;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = new HostBuilder()
    .ConfigureFunctionsWebApplication()
    .ConfigureServices((context, services) =>
    {
        Microsoft.Extensions.Configuration.IConfiguration config = context.Configuration;

        services.AddApplication();
        services.AddInfrastructure(config);

        services.AddApplicationInsightsTelemetryWorkerService();
        services.ConfigureFunctionsApplicationInsights();
    })
    .Build();

host.Run();
