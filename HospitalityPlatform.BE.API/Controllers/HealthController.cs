using Microsoft.AspNetCore.Mvc;

namespace HospitalityPlatform.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new
        {
            status = "ok",
            service = "HospitalityPlatform.Api",
            utcTime = DateTime.UtcNow
        });
    }
}
