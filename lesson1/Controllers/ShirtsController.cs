using lesson1.Filters;
using lesson1.Models;
using lesson1.Models.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace lesson1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController: ControllerBase
    {

        [HttpGet]
        public IActionResult GetShirts()
        {
            return Ok(ShirtRepository.GetShirts());
        }

        [HttpGet("{id}")]
        [Shirt_ValidateShirtIdFilter]
        public IActionResult GetShirtById(int id)
        {
            return Ok(ShirtRepository.GetShirtById(id));
        }

        [HttpPost]
        public IActionResult CreateShirt([FromBody]Shirt shirt)
        {
            return Ok($"Created a shirt.");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateShirt(int id)
        {
            return Ok($"Updated shirt with id: {id}");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteShirt(int id)
        {
            return Ok($"Deleted shirt with id: {id}");
        }
    }
}
