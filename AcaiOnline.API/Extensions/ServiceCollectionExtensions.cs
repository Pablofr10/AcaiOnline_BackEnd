using AcaiOnline.Core.Interfaces.Repositories;
using AcaiOnline.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace AcaiOnline.API.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepository(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}