using System.ComponentModel.DataAnnotations;

namespace HospitalityPlatform.Api.DTOs.Locations;

public class UpdateLocationDto
{
    [Required, MaxLength(120)]
    public string Name { get; set; } = string.Empty;

    [Required, MaxLength(80)]
    public string City { get; set; } = string.Empty;

    [Required, MaxLength(1000)]
    public string Description { get; set; } = string.Empty;

    [Url, MaxLength(1000)]
    public string ImageUrl { get; set; } = string.Empty;

    [Required, MaxLength(80)]
    public string Category { get; set; } = string.Empty;

    [Required, MaxLength(200)]
    public string Address { get; set; } = string.Empty;

    public bool IsFeatured { get; set; }
}
