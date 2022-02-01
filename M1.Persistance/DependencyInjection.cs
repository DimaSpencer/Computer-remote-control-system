using M1.Application.Interfaces.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace M1.Persistance;

public static class DependencyInjection
{
    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
    {
        string connectionString = configuration.GetConnectionString("ConnectionStrings:Database");
        services.AddDbContext<AppDbContext>(o => o.UseSqlite(connectionString));

        services.AddScoped<IAppDbContext, AppDbContext>();

        return services;
    }
}
