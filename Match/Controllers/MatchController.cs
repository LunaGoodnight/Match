using Microsoft.AspNetCore.Mvc;

namespace Match.Controllers;

public class MatchController : Controller
{
    private readonly ILogger<WeatherForecastController> _logger;

    public MatchController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }
}