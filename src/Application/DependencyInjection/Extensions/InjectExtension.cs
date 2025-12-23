using Application.Behaviors;
using Microsoft.Extensions.DependencyInjection;
using System;
namespace Application.DependencyInjection.Extensions
{
    public static class InjectExtension
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining<AssemblyMarker>();
                cfg.AddOpenBehavior(typeof(LoggingBehavior<,>));
            });
            return services;
        }
    }
}
