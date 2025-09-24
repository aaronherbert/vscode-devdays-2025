var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.vscode_devdays_2025_ApiService>("apiservice");

builder.AddProject<Projects.vscode_devdays_2025_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
