using HospitalityPlatform.Api.DTOs.Bookings;
using HospitalityPlatform.Api.Models;

namespace HospitalityPlatform.Api.Mappings;

public static class BookingMappings
{
    public static BookingResponseDto ToResponseDto(this Booking entity)
    {
        return new BookingResponseDto
        {
            Id = entity.Id,
            LocationId = entity.LocationId,
            LocationName = entity.Location?.Name,
            FullName = entity.FullName,
            Email = entity.Email,
            Phone = entity.Phone,
            Date = entity.Date,
            Guests = entity.Guests,
            Notes = entity.Notes,
            Status = entity.Status,
            CreatedAtUtc = entity.CreatedAtUtc
        };
    }
}
