using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private IFoo _foo;

        public TestController(IFoo foo)
        {
            _foo = foo;
        }
       
        private void AddToRandList(List<int> randList)
        {
            randList.Add(_foo.RandInt);
            randList.Add(_foo.RandInt);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var _randList = new List<int>();
            AddToRandList(_randList);
            return Ok(_randList);
        }
    }
}