using HospitalityPlatform.Api.DTOs.ContactRequests;
using HospitalityPlatform.Api.Models;

namespace HospitalityPlatform.Api.Mappings;

public static class ContactRequestMappings
{
    public static ContactRequestResponseDto ToResponseDto(this ContactRequest entity)
    {
        return new ContactRequestResponseDto
        {
            Id = entity.Id,
            FullName = entity.FullName,
            Email = entity.Email,
            Subject = entity.Subject,
            Message = entity.Message,
            Status = entity.Status,
            CreatedAtUtc = entity.CreatedAtUtc
        };
    }
}
