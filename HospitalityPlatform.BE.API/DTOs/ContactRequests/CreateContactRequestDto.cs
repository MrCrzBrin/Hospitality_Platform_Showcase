using System.ComponentModel.DataAnnotations;

namespace HospitalityPlatform.Api.DTOs.ContactRequests;

public class CreateContactRequestDto
{
    [Required, MaxLength(120)]
    public string FullName { get; set; } = string.Empty;

    [Required, EmailAddress, MaxLength(200)]
    public string Email { get; set; } = string.Empty;

    [Required, MaxLength(180)]
    public string Subject { get; set; } = string.Empty;

    [Required, MaxLength(3000)]
    public string Message { get; set; } = string.Empty;
}
