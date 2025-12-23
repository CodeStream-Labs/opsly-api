using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Services.DependencyInjection.Extensions
{
    public static class InjectExtension
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services;
        }
    }
}

