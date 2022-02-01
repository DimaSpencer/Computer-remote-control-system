using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace M1.Application.Interfaces.Extensions;

public static class DependencyInjection
{
    public static IServiceCollection AddM1Application(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());
        return services;
    }
}
