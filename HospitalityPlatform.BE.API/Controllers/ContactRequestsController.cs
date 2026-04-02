using HospitalityPlatform.Api.DTOs.ContactRequests;
using HospitalityPlatform.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace HospitalityPlatform.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContactRequestsController : ControllerBase
{
    private readonly IContactRequestService _contactRequestService;

    public ContactRequestsController(IContactRequestService contactRequestService)
    {
        _contactRequestService = contactRequestService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var result = await _contactRequestService.GetAllAsync(cancellationToken);
        return Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateContactRequestDto dto, CancellationToken cancellationToken)
    {
        if (!ModelState.IsValid)
        {
            return ValidationProblem(ModelState);
        }

        var created = await _contactRequestService.CreateAsync(dto, cancellationToken);
        return Ok(created);
    }
}
