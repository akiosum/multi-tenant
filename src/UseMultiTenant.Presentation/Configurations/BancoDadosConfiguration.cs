namespace UseMultiTenant.Presentation.Configurations;

public static class BancoDadosConfiguration
{
    public static IServiceCollection AdicionarBancoDados(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        return services;
    }
}