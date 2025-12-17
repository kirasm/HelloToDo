var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.HelloTodo_API>("hellotodo-api");

builder.Build().Run();
