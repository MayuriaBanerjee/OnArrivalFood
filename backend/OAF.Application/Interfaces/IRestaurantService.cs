
using OAF.Domain.Entities;

namespace OAF.Application.Interfaces;

public interface IRestaurantService
{
    Task<List<Restaurant>> GetRestaurantsAsync();
}