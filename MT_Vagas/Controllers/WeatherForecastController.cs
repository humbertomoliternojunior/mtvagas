using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MT_Vagas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MT_Vagas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        
        {
            Categoria cat = new Categoria();
            cat.Nome = "TI";
            Emprego obj = new Emprego(cat);
            return obj.NomeCategoria;

           
        }
    }
}
