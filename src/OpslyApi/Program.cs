using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Microsoft.OpenApi.Models;
using OpslyApi.Configurations;

namespace OpslyApi
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();

            builder.Services.AddApiVersioning(options =>
            {
                options.DefaultApiVersion = new ApiVersion(1, 0);

                options.AssumeDefaultVersionWhenUnspecified = true;

                options.ReportApiVersions = true;
            });

            builder.Services.AddVersionedApiExplorer(options =>
            {
                options.GroupNameFormat = "'v'VVV";

                options.SubstituteApiVersionInUrl = true;
            });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.ConfigureOptions<ConfigureSwaggerOptions>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                var provider = app.Services.GetRequiredService<IApiVersionDescriptionProvider>();

                app.UseSwagger();
                app.UseSwaggerUI(options =>
                {
                    foreach (var description in provider.ApiVersionDescriptions)
                    {
                        options.SwaggerEndpoint(
                            $"/swagger/{description.GroupName}/swagger.json",
                            description.GroupName.ToUpperInvariant());
                    }
                });
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();

            app.Run();
        }
    }
}