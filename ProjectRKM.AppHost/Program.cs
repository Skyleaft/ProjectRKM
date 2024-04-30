var builder = DistributedApplication.CreateBuilder(args);

var postgresdb = builder.AddPostgres("pg")
                        .AddDatabase("postgresdb");

builder.AddProject<Projects.RKM_API>("rkm-api")
    .WithReference(postgresdb);

builder.Build().Run();
