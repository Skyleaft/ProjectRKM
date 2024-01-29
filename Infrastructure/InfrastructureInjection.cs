using Microsoft.Extensions.DependencyInjection;
using Mediator;
using Microsoft.AspNetCore.Builder;
using FastEndpoints;

namespace Infrastructure;
public static class InfrastructureInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        //Mediator
        //services.AddMediator(options =>
        //{
        //    options.Namespace = "Mzstudio.Infrastructure";
        //    options.ServiceLifetime = ServiceLifetime.Transient;
        //});

        services.AddFastEndpoints();

        return services;
    }

    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
    {
        app.UseFastEndpoints();
        return app;
    }
}
