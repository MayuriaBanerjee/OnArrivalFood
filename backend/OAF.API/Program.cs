using OAF.Application.Interfaces;
using OAF.Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<IRestaurantService, RestaurantService>();

var app = builder.Build();

app.UseHttpsRedirection();

app.MapControllers();

app.Run();