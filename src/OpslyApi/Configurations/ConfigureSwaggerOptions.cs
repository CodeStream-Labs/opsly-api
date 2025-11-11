using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace OpslyApi.Configurations
{
    public class ConfigureSwaggerOptions : IConfigureOptions<SwaggerGenOptions>
    {
        private readonly IApiVersionDescriptionProvider _provider;

        public ConfigureSwaggerOptions(IApiVersionDescriptionProvider provider)
        {
            _provider = provider;
        }

        public void Configure(SwaggerGenOptions options)
        {
            foreach (var description in _provider.ApiVersionDescriptions)
            {
                options.SwaggerDoc(description.GroupName, new OpenApiInfo
                {
                    Title = $"Opsly API {description.ApiVersion}",
                    Version = description.ApiVersion.ToString(),
                    Description = "Plataforma de orquestração de tarefas automatizadas (inspirada no Rundeck).",
                    Contact = new OpenApiContact
                    {
                        Name = "Equipe CodeStream Labs",
                        Email = "contato@cslabs.dev",
                        Url = new Uri("https://github.com/CodeStream-Labs")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "MIT License",
                        Url = new Uri("https://opensource.org/licenses/MIT")
                    }
                });
            }
        }
    }
}