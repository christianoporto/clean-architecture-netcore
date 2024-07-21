using CleanArchitectureApp.Application.Interfaces.Persistence;
using CleanArchitectureApp.Domain.Entities;
using CleanArchitectureApp.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitectureApp.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IRepository<Form>, FormRepository>();
            return services;
        }
    }
}
