using Microsoft.AspNetCore.Mvc;
using MediatR;
using System.Threading.Tasks;
using Template.Application.Querys.LastWeatherForecast;
using Serilog;

namespace Template.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private ILogger Logger { get; }
        private IMediator Mediator { get; }
        public WeatherForecastController(ILogger logger, IMediator mediator)
        {
            Logger = logger;
            Mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var request = new LastWeatherForecastRequest() { };
            var response = await Mediator.Send(request);
            Logger.Information<LastWeatherForecastResponse>("Response: {@Response}", response);
            return Ok(response);
        }
    }
}
