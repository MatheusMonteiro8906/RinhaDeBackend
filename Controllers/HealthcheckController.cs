using RinhaDeBackend.Models;
using Microsoft.AspNetCore.Mvc;

namespace RinhaDeBackend.Controllers;

[ApiController]
[Route("[controller]")]
public class HealthcheckController : ControllerBase
{
    [HttpGet]
    public ActionResult<string> HealthCheckGetter()
    {
        return Ok("Api is healthy and running");
    }
}