using System.Text.Json;
using OAF.Application.Interfaces;
using OAF.Domain.Entities;

namespace OAF.Infrastructure.Services;

public class RestaurantService : IRestaurantService
{
    public async Task<List<Restaurant>> GetRestaurantsAsync()
    {
        var filePath = Path.Combine(
            Directory.GetCurrentDirectory(),
            "Data",
            "restaurants.json");

        var jsonData = await File.ReadAllTextAsync(filePath);

        var restaurants = JsonSerializer.Deserialize<List<Restaurant>>(
            jsonData,
            new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

        return restaurants ?? new List<Restaurant>();
    }
}