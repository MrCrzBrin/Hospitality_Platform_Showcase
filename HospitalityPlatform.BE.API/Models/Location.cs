namespace HospitalityPlatform.Api.Models;

public class Location : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public bool IsFeatured { get; set; }

    public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
}
