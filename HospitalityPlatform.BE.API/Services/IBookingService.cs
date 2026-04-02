using HospitalityPlatform.Api.DTOs.Bookings;

namespace HospitalityPlatform.Api.Services;

public interface IBookingService
{
    Task<IReadOnlyList<BookingResponseDto>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<BookingResponseDto> CreateAsync(CreateBookingDto dto, CancellationToken cancellationToken = default);
}
