using HospitalityPlatform.Api.DTOs.Locations;
using HospitalityPlatform.Api.Mappings;
using HospitalityPlatform.Api.Models;
using HospitalityPlatform.Api.Repositories;

namespace HospitalityPlatform.Api.Services;

public class LocationService : ILocationService
{
    private readonly ILocationRepository _locationRepository;

    public LocationService(ILocationRepository locationRepository)
    {
        _locationRepository = locationRepository;
    }

    public async Task<IReadOnlyList<LocationResponseDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var locations = await _locationRepository.GetAllAsync(cancellationToken);
        return locations.Select(x => x.ToResponseDto()).ToList();
    }

    public async Task<LocationResponseDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var location = await _locationRepository.GetByIdAsync(id, cancellationToken);
        return location?.ToResponseDto();
    }

    public async Task<LocationResponseDto> CreateAsync(CreateLocationDto dto, CancellationToken cancellationToken = default)
    {
        var entity = new Location
        {
            Name = dto.Name,
            City = dto.City,
            Description = dto.Description,
            ImageUrl = dto.ImageUrl,
            Category = dto.Category,
            Address = dto.Address,
            IsFeatured = dto.IsFeatured
        };

        var created = await _locationRepository.AddAsync(entity, cancellationToken);
        return created.ToResponseDto();
    }

    public async Task<LocationResponseDto?> UpdateAsync(Guid id, UpdateLocationDto dto, CancellationToken cancellationToken = default)
    {
        var entity = await _locationRepository.GetByIdAsync(id, cancellationToken);
        if (entity is null)
        {
            return null;
        }

        entity.Name = dto.Name;
        entity.City = dto.City;
        entity.Description = dto.Description;
        entity.ImageUrl = dto.ImageUrl;
        entity.Category = dto.Category;
        entity.Address = dto.Address;
        entity.IsFeatured = dto.IsFeatured;

        var updated = await _locationRepository.UpdateAsync(entity, cancellationToken);
        return updated.ToResponseDto();
    }

    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        var entity = await _locationRepository.GetByIdAsync(id, cancellationToken);
        if (entity is null)
        {
            return false;
        }

        return await _locationRepository.DeleteAsync(entity, cancellationToken);
    }
}
