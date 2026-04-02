using HospitalityPlatform.Api.DTOs.Bookings;
using HospitalityPlatform.Api.Mappings;
using HospitalityPlatform.Api.Models;
using HospitalityPlatform.Api.Repositories;

namespace HospitalityPlatform.Api.Services;

public class BookingService : IBookingService
{
    private readonly IBookingRepository _bookingRepository;
    private readonly ILocationRepository _locationRepository;

    public BookingService(IBookingRepository bookingRepository, ILocationRepository locationRepository)
    {
        _bookingRepository = bookingRepository;
        _locationRepository = locationRepository;
    }

    public async Task<IReadOnlyList<BookingResponseDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var bookings = await _bookingRepository.GetAllAsync(cancellationToken);
        return bookings.Select(x => x.ToResponseDto()).ToList();
    }

    public async Task<BookingResponseDto> CreateAsync(CreateBookingDto dto, CancellationToken cancellationToken = default)
    {
        var location = await _locationRepository.GetByIdAsync(dto.LocationId, cancellationToken);
        if (location is null)
        {
            throw new KeyNotFoundException("Location was not found.");
        }

        var entity = new Booking
        {
            LocationId = dto.LocationId,
            FullName = dto.FullName,
            Email = dto.Email,
            Phone = dto.Phone,
            Date = dto.Date,
            Guests = dto.Guests,
            Notes = dto.Notes,
            Status = "Pending"
        };

        var created = await _bookingRepository.AddAsync(entity, cancellationToken);
        created.Location = location;
        return created.ToResponseDto();
    }
}
