using Microsoft.Extensions.DependencyInjection;
using Mediator;
using Microsoft.AspNetCore.Builder;
using FastEndpoints;
using RKM.Infrastructure.Data;

namespace RKM.Infrastructure;
public static class InfrastructureInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection Services)
    {
        //Mediator
        //Services.AddMediator(options =>
        //{
        //    options.Namespace = "Mzstudio.Infrastructure";
        //    options.ServiceLifetime = ServiceLifetime.Transient;
        //});
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        Services.AddTransient<GenericRepository>();

        Services.AddFastEndpoints();

        return Services;
    }

    public static IApplicationBuilder UseInfrastructure(this IApplicationBuilder app)
    {
        app.UseFastEndpoints();
        return app;
    }
}
