using Microsoft.Extensions.DependencyInjection;

namespace Core.Utils.IoC;

public static class ServiceTool
{
    public static IServiceProvider ServiceProvider { get; private set; } = null!;

    public static IServiceCollection Create(IServiceCollection services)
    {
        ServiceProvider = services.BuildServiceProvider();
        return services;
    }
}