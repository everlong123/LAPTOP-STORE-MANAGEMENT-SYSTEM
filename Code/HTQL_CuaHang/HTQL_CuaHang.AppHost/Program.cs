var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.HTQL_CuaHang>("htql-cuahang");

builder.Build().Run();
