using ApiSample.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiSample.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly ApiSample.Services.HugeDataService _data;

    public PersonController(ILogger<WeatherForecastController> logger,
        ApiSample.Services.HugeDataService data)
    {
        _logger = logger;
        _data = data;
    }

    [HttpGet(Name = "GetPersons")]
    public IAsyncEnumerable<Person> Get()
    {
        return _data.LoadManyPersons();
    }
}
