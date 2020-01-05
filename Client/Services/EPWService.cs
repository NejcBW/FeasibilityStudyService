using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherGen;
using Microsoft.AspNetCore.Components;

namespace Client.Services
{
    public class EPWService
    {
        private HttpClient _http;

        public EPWService(HttpClient http)
        {
            _http = http;
        }

        public async Task<EPW> GetEPW()
        {
            var epw = await _http.GetJsonAsync<EPW>("/EPW");
            Console.WriteLine($"City: {epw.Location.City}");
            return epw;
        }
    }
}
