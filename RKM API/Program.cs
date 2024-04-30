using FastEndpoints.Security;
using Microsoft.AspNetCore.Http.Json;
using RKM.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
builder.Services.AddTransient<GenericRepository>();
builder.AddNpgsqlDbContext<GenericRepository>("postgresdb");
builder
    .Services
    .AddAuthenticationJwtBearer(o => o.SigningKey = builder.Configuration["Auth:SigningKey"])
    .AddAuthorization()
    .AddFastEndpoints();

builder.Services.Configure<JsonOptions>(o =>
    o.SerializerOptions.PropertyNamingPolicy = null);

builder.Services.SwaggerDocument(
        d => d.DocumentSettings =
                 s =>
                 {
                     s.DocumentName = "v0";
                     s.Version = "0.0.0";
                 });

var app = builder.Build();
app.MapDefaultEndpoints();
app.UseDefaultExceptionHandler();
app.UseAuthentication()
   .UseAuthorization()
   .UseFastEndpoints(c =>
   {
       c.Endpoints.RoutePrefix = "api";
       c.Serializer.Options.PropertyNamingPolicy = null;
   }
);
app.UseSwaggerGen(uiConfig: u => u.DeActivateTryItOut());
app.Run();

