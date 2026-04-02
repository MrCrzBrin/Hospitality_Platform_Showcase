using HospitalityPlatform.Api.DTOs.Locations;
using HospitalityPlatform.Api.Models;

namespace HospitalityPlatform.Api.Mappings;

public static class LocationMappings
{
    public static LocationResponseDto ToResponseDto(this Location entity)
    {
        return new LocationResponseDto
        {
            Id = entity.Id,
            Name = entity.Name,
            City = entity.City,
            Description = entity.Description,
            ImageUrl = entity.ImageUrl,
            Category = entity.Category,
            Address = entity.Address,
            IsFeatured = entity.IsFeatured,
            CreatedAtUtc = entity.CreatedAtUtc
        };
    }
}
