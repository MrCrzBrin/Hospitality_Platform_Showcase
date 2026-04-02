using HospitalityPlatform.Api.DTOs.Locations;

namespace HospitalityPlatform.Api.Services;

public interface ILocationService
{
    Task<IReadOnlyList<LocationResponseDto>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<LocationResponseDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<LocationResponseDto> CreateAsync(CreateLocationDto dto, CancellationToken cancellationToken = default);
    Task<LocationResponseDto?> UpdateAsync(Guid id, UpdateLocationDto dto, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}
