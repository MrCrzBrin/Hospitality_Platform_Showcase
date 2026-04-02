namespace HospitalityPlatform.Api.Models;

public class Booking : BaseEntity
{
    public Guid LocationId { get; set; }
    public Location? Location { get; set; }

    public string FullName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public DateOnly Date { get; set; }
    public int Guests { get; set; }
    public string Notes { get; set; } = string.Empty;
    public string Status { get; set; } = "Pending";
}
