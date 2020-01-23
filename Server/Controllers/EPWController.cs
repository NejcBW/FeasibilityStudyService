using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WeatherGen;

namespace Server.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class EPWController : ControllerBase
    {
        private readonly string filePath =
            @"./wwwroot/WeatherFiles/WAW.epw";

        //@"C:\Users\Lenovo\source\repos\FeasibilityStudyService\Server\wwwroot\WeatherFiles\WAW.epw"

        private EPW _epw;
        public EPWController(EPW epw)
        {
            _epw = epw;
            _epw.SetLocation(filePath);
        }

        [HttpGet]
        public EPW Get()
        {
            return _epw;
        }

    }
}