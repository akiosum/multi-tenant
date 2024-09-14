using Microsoft.OpenApi.Models;

namespace UseMultiTenant.Presentation.Configurations;

public static class SwaggerConfiguration
{
    public static IServiceCollection AdicionarSwagger(
        this IServiceCollection services)
    {
        services.AddSwaggerGen(sw =>
        {
            sw.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "MultiTenant Exemplo API",
                Version = "v1",
                Description = "Demostrativo do funcionamento de multitentant"
            });
        });

        return services;
    }
}