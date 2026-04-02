using HospitalityPlatform.Api.Models;

namespace HospitalityPlatform.Api.Repositories;

public interface ILocationRepository
{
    Task<IReadOnlyList<Location>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Location?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<Location> AddAsync(Location location, CancellationToken cancellationToken = default);
    Task<Location> UpdateAsync(Location location, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(Location location, CancellationToken cancellationToken = default);
}
