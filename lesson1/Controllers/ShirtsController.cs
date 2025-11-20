using lesson1.Models;
using Microsoft.AspNetCore.Mvc;

namespace lesson1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ShirtsController: ControllerBase
    {
        [HttpGet]
        public string GetShirts()
        {
            return "Here are your shirts!";
        }

        [HttpGet("{id}")]
        public string GetShirtById(int id)
        {
            return $"Here is shirt with id: {id}";
        }

        [HttpPost]
        public string CreateShirt([FromBody]Shirt shirt)
        {
            return $"Created a shirt.";
        }

        [HttpPut("{id}")]
        public string UpdateShirt(int id)
        {
            return $"Updated shirt with id: {id}";
        }

        [HttpDelete("{id}")]
        public string DeleteShirt(int id)
        {
            return $"Deleted shirt with id: {id}";
        }
    }
}
