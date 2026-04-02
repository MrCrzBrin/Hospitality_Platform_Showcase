using HospitalityPlatform.Api.DTOs;
using HospitalityPlatform.Api.Models;

namespace HospitalityPlatform.Api.Mappings;

public static class ProductMappingExtensions
{
    public static ProductResponseDto ToResponseDto(this Product product)
    {
        return new ProductResponseDto
        {
            Id = product.Slug,
            Name = product.Name,
            Category = product.Category,
            Profile = product.Profile,
            Origin = product.Origin,
            Image = product.ImageUrl,
            Description = product.Description,
            Tags = product.Tags
        };
    }

    public static Product ToEntity(this CreateProductDto dto)
    {
        return new Product
        {
            Id = Guid.NewGuid(),
            Slug = dto.Slug,
            Name = dto.Name,
            Category = dto.Category,
            Profile = dto.Profile,
            Origin = dto.Origin,
            ImageUrl = dto.ImageUrl,
            Description = dto.Description,
            Tags = dto.Tags,
            IsFeatured = dto.IsFeatured,
            CreatedAtUtc = DateTime.UtcNow
        };
    }
}