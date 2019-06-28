using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DotnetDemo.Controllers
{
    [Route("demo/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // GET demo/hello
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Hello", "Dotnet" };
        }

        // GET demo/hello/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "Hello, Dotnet!";
        }

        // POST demo/hello
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }
    }
}
