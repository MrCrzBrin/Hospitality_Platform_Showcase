using HospitalityPlatform.Api.Data;
using HospitalityPlatform.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalityPlatform.Api.Repositories;

public class ContactRequestRepository : IContactRequestRepository
{
    private readonly AppDbContext _db;

    public ContactRequestRepository(AppDbContext db)
    {
        _db = db;
    }

    public async Task<IReadOnlyList<ContactRequest>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        return await _db.ContactRequests
            .OrderByDescending(x => x.CreatedAtUtc)
            .ToListAsync(cancellationToken);
    }

    public async Task<ContactRequest> AddAsync(ContactRequest contactRequest, CancellationToken cancellationToken = default)
    {
        _db.ContactRequests.Add(contactRequest);
        await _db.SaveChangesAsync(cancellationToken);
        return contactRequest;
    }
}
