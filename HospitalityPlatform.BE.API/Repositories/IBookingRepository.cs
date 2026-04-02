using HospitalityPlatform.Api.Models;

namespace HospitalityPlatform.Api.Repositories;

public interface IBookingRepository
{
    Task<IReadOnlyList<Booking>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<Booking> AddAsync(Booking booking, CancellationToken cancellationToken = default);
}
