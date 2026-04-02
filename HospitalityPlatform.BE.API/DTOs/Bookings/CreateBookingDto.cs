using System.ComponentModel.DataAnnotations;

namespace HospitalityPlatform.Api.DTOs.Bookings;

public class CreateBookingDto
{
    [Required]
    public Guid LocationId { get; set; }

    [Required, MaxLength(120)]
    public string FullName { get; set; } = string.Empty;

    [Required, EmailAddress, MaxLength(200)]
    public string Email { get; set; } = string.Empty;

    [MaxLength(50)]
    public string Phone { get; set; } = string.Empty;

    [Required]
    public DateOnly Date { get; set; }

    [Range(1, 30)]
    public int Guests { get; set; }

    [MaxLength(1000)]
    public string Notes { get; set; } = string.Empty;
}
