var builder = DistributedApplication.CreateBuilder(args);


builder.AddProject<Projects.RKM_API>("rkm-api");

builder.Build().Run();
