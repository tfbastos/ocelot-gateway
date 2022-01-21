using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json");
builder.Services.AddOcelot();
//builder.Logging.AddConsole();

var app = builder.Build();
app.UseOcelot().Wait();
app.Run();

