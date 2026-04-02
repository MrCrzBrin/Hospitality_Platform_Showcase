namespace HospitalityPlatform.Api.DTOs.Bookings;

public class BookingResponseDto
{
    public Guid Id { get; set; }
    public Guid LocationId { get; set; }
    public string? LocationName { get; set; }
    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateOnly Date { get; set; }
    public int Guests { get; set; }
    public string Notes { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public DateTime CreatedAtUtc { get; set; }
}
