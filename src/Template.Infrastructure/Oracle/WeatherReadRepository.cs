using System;
using System.Collections.Generic;
using System.Linq;
using Serilog;
using Template.Domain.Entidades;
using Template.Domain.Repositorios;

namespace Template.Infrastructure.Oracle
{
    public class WeatherReadRepository : IWeatherReadRepository
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private ILogger Logger { get; }

        public WeatherReadRepository(ILogger logger)
        {
            Logger = logger;
        }
        public List<WeatherForecast> Find()
        {
            var rng = new Random();

            Logger.Information("Getting last five wheather forecast");
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToList();

        }
    }
}