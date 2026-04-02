using HospitalityPlatform.Api.Models;

namespace HospitalityPlatform.Api.Repositories;

public interface IContactRequestRepository
{
    Task<IReadOnlyList<ContactRequest>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<ContactRequest> AddAsync(ContactRequest contactRequest, CancellationToken cancellationToken = default);
}
