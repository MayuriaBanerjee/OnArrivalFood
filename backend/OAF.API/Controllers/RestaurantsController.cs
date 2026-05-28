
using Microsoft.AspNetCore.Mvc;
using OAF.Application.Interfaces;

namespace OAF.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class RestaurantsController : ControllerBase
{
    private readonly IRestaurantService _restaurantService;

    public RestaurantsController(IRestaurantService restaurantService)
    {
        _restaurantService = restaurantService;
    }

    [HttpGet]
    public async Task<IActionResult> GetRestaurants()
    {
        var restaurants = await _restaurantService.GetRestaurantsAsync();

        return Ok(restaurants);
    }
}