namespace UseMultiTenant.Presentation.Configurations;

public static class ApiConfiguration
{
    public static IServiceCollection AdicionarConfiguracoes(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddControllers()
            .ConfigureApiBehaviorOptions(conf => { conf.SuppressModelStateInvalidFilter = true; });
        services.AddEndpointsApiExplorer();

        services.AdicionarSwagger();
        // services.AdicionarBancoDados(configuration);
        services.AdicionarIoC();

        return services;
    }
}