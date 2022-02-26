
using MedErp.Infrastructure;

namespace Microsoft.Extensions.DependencyInjection;
public static class IServiceCollectionExtensions
{
    public static IServiceCollection AddDatabaseConectionStrings(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IDatabaseConnectionString>((serviceProvider) => new DatabaseConnectionString(configuration.GetConnectionString("Connection_DEV")));
        //services.AddSingleton<IDatabaseReadOnlyConnectionString>((serviceProvider) => new DatabaseConnectionString(configuration.GetConnectionString("SchedulingRules-readonly")));

        return services;
    }
}