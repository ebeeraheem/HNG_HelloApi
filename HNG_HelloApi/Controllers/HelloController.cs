using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HNG_HelloApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class HelloController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery] string visitor_name)
    {
        var name = visitor_name is null ? "client" : visitor_name;
        var clientIp = HttpContext.Connection.RemoteIpAddress?.ToString();
        var response = new
        {
            client_ip = clientIp ?? "Unknown",
            greeting = $"Hello, {name}!"
        };

        return Ok(response);
    }
}
