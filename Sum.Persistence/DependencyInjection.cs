using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sum.Persistence.Interceptors;

namespace Sum.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");

        services.AddDbContext<SumCommerceDbContext>((sp, options) =>
        {
            options.UseSqlServer(connectionString).AddInterceptors(new SlowQueryInterceptor());
        });

        return services;
    }
}
