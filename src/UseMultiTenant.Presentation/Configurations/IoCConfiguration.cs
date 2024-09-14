using Microsoft.Extensions.FileSystemGlobbing.Internal;
using UseMultiTenant.Application;
using UseMultiTenant.Application.Contracts.Services;
using UseMultiTenant.Domain;
using UseMultiTenant.Domain.Contracts.Repositories;
using UseMultiTenant.Infra;

namespace UseMultiTenant.Presentation.Configurations;

public static class IoCConfiguration
{
    public static IServiceCollection AdicionarIoC(this IServiceCollection services)
    {
        services.AdicionarRepository();
        services.AdicionarServices();

        return services;
    }

    private static void AdicionarServices(this IServiceCollection services)
    {
        services.Scan(scan => scan.FromAssemblies(ApplicationAssembly.Assembly)
            .AddClasses(filter => filter.AssignableTo<IService>())
            .AsImplementedInterfaces()
            .WithScopedLifetime());
    }

    private static void AdicionarRepository(this IServiceCollection services)
    {
        services.Scan(scan => scan.FromAssemblies(DomainAssembly.Assembly, InfrastructureAssembly.Assembly)
            .AddClasses(filter => filter.AssignableTo<IRepository>())
            .AsImplementedInterfaces()
            .WithScopedLifetime());
    }
}