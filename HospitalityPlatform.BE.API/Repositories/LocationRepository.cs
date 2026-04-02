using HospitalityPlatform.Api.Data;
using HospitalityPlatform.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalityPlatform.Api.Repositories;

public class LocationRepository : ILocationRepository
{
    private readonly AppDbContext _db;

    public LocationRepository(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IReadOnlyList<Location>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _db.Locations
            .OrderByDescending(x => x.IsFeatured)
            .ThenBy(x => x.Name)
            .ToListAsync(cancellationToken);
    }

    public async Task<Location?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _db.Locations.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
    }

    public async Task<Location> AddAsync(Location location, CancellationToken cancellationToken = default)
    {
        _db.Locations.Add(location);
        await _db.SaveChangesAsync(cancellationToken);
        return location;
    }

    public async Task<Location> UpdateAsync(Location location, CancellationToken cancellationToken = default)
    {
        _db.Locations.Update(location);
        await _db.SaveChangesAsync(cancellationToken);
        return location;
    }

    public async Task<bool> DeleteAsync(Location location, CancellationToken cancellationToken = default)
    {
        _db.Locations.Remove(location);
        return await _db.SaveChangesAsync(cancellationToken) > 0;
    }
}
