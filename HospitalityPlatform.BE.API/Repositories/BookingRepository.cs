using HospitalityPlatform.Api.Data;
using HospitalityPlatform.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalityPlatform.Api.Repositories;

public class BookingRepository : IBookingRepository
{
    private readonly AppDbContext _db;

    public BookingRepository(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IReadOnlyList<Booking>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _db.Bookings
            .Include(x => x.Location)
            .OrderByDescending(x => x.CreatedAtUtc)
            .ToListAsync(cancellationToken);
    }

    public async Task<Booking> AddAsync(Booking booking, CancellationToken cancellationToken = default)
    {
        _db.Bookings.Add(booking);
        await _db.SaveChangesAsync(cancellationToken);
        return booking;
    }
}
