using HospitalityPlatform.Api.DTOs.ContactRequests;

namespace HospitalityPlatform.Api.Services;

public interface IContactRequestService
{
    Task<IReadOnlyList<ContactRequestResponseDto>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<ContactRequestResponseDto> CreateAsync(CreateContactRequestDto dto, CancellationToken cancellationToken = default);
}
