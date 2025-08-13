using Microsoft.AspNetCore.Mvc;
using System;

namespace RequestLifeCycleDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        // GET: /test/success
        [HttpGet("success")]
        public IActionResult Success()
        {
            Console.WriteLine("Controller: Success action running");
            return Ok(new { message = "Hello from API" });
        }

        // GET: /test/error
        [HttpGet("error")]
        public IActionResult Error()
        {
            Console.WriteLine("Controller: Error action running");
            throw new Exception("Something went wrong!");
        }

        // POST: /test
        [HttpPost]
        public IActionResult Create([FromBody] object data)
        {
            Console.WriteLine("Controller: Create action running");
            return Ok(new { message = "Created successfully", data });
        }

        // PUT: /test/{id}
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] object data)
        {
            Console.WriteLine("Controller: Update action running");
            return Ok(new { message = $"Updated item {id}", data });
        }

        // DELETE: /test/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Console.WriteLine("Controller: Delete action running");
            return Ok(new { message = $"Deleted item {id}" });
        }
    }
}
