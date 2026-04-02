namespace HospitalityPlatform.Api.Models;

public class Product
{
    public Guid Id { get; set; }

    public string Slug { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Profile { get; set; } = string.Empty;
    public string Origin { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;

    public List<string> Tags { get; set; } = new();

    public bool IsFeatured { get; set; }
    
    public DateTime CreatedAtUtc { get; set; }
}