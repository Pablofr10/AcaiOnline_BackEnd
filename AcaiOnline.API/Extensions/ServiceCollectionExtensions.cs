using AcaiOnline.Application.Services;
using AcaiOnline.Core.Interfaces.Repositories;
using AcaiOnline.Core.Interfaces.Services;
using AcaiOnline.Infrastructure.Repositories;
using AutoMapper;
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
            services.AddScoped<IPedidoService, PedidoService>();
            services.AddScoped<IProdutoService, ProdutoService>();
            return services;
        }
    }
}