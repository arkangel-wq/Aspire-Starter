var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.Aspire_Starter_ApiService>("apiservice");

builder.AddProject<Projects.Aspire_Starter_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
