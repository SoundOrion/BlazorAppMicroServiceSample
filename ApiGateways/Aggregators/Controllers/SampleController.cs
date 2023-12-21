using Aggregators.Services;
using Microsoft.AspNetCore.Mvc;

namespace Aggregators.Controllers;

[Route("api/v1/[controller]")]
[ApiController]
public class SampleController(IGreeterService greeter) : ControllerBase
{
    private readonly IGreeterService _greeter = greeter;

    [HttpGet]
    //[HttpPost]
    //[HttpPut]
    public async Task<string> SayHelloAsync()
    {
        var message = await _greeter.SayHello();
        return message;
    }
}