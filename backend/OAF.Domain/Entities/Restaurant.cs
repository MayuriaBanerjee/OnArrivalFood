namespace OAF.Domain.Entities;

public class Restaurant
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Location { get; set; } = string.Empty;

    public double Rating { get; set; }

    public int AvailableSeats { get; set; }

    public string Cuisine { get; set; } = string.Empty;

    public string DeliveryTime { get; set; } = string.Empty;

    public string PriceRange { get; set; } = string.Empty;

    public string ImageUrl { get; set; } = string.Empty;

    public string Description { get; set; } = string.Empty;
}