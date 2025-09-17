using IMS.Domain;
using IMS.Domain.Repositories;
using IMS.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace IMS.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddDependencyInjection(this IServiceCollection service)
        {
            service.AddScoped<IProductRepository, ProductRepository>();
            service.AddScoped<IApplicationUnitOfWork, ApplicationUnitOfWork>();
        }
    }
}
