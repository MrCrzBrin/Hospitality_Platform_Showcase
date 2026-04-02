using HospitalityPlatform.Api.DTOs.ContactRequests;
using HospitalityPlatform.Api.Mappings;
using HospitalityPlatform.Api.Models;
using HospitalityPlatform.Api.Repositories;

namespace HospitalityPlatform.Api.Services;

public class ContactRequestService : IContactRequestService
{
    private readonly IContactRequestRepository _contactRequestRepository;

    public ContactRequestService(IContactRequestRepository contactRequestRepository)
    {
        _contactRequestRepository = contactRequestRepository;
    }

    public async Task<IReadOnlyList<ContactRequestResponseDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        var items = await _contactRequestRepository.GetAllAsync(cancellationToken);
        return items.Select(x => x.ToResponseDto()).ToList();
    }

    public async Task<ContactRequestResponseDto> CreateAsync(CreateContactRequestDto dto, CancellationToken cancellationToken = default)
    {
        var entity = new ContactRequest
        {
            FullName = dto.FullName,
            Email = dto.Email,
            Subject = dto.Subject,
            Message = dto.Message,
            Status = "New"
        };

        var created = await _contactRequestRepository.AddAsync(entity, cancellationToken);
        return created.ToResponseDto();
    }
}
