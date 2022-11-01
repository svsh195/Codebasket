using Dices.Startup;

var builder = WebApplication.CreateBuilder(args);

builder.Services.RegisterServices();

var app = builder.Build();

app.ConfigureSwagger();

app.UseHttpsRedirection();

app.MapDiceEndpoints();

app.Run();