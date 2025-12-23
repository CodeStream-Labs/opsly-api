using OpslyApi.Mappers;

namespace OpslyApi.Configurations
{
    public static class AutoMapperConfiguration
    {
        public static IServiceCollection AddMappers(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(TaskProfile));
            return services;
        }
    }
}
