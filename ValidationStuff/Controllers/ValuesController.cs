using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ValidationStuff.Models;

namespace ValidationStuff.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        [HttpPost("animal")]
        public IActionResult Post(Animal animal)
        {
            if (animal.Sex != "M" && animal.Sex != "F")
            {
                var x = new ModelStateDictionary();
                x.AddModelError("Sex","Must be 'M' or 'F'");

                return BadRequest(x);
            }

            return Ok();
        }

        [HttpPost("automobile")]
        public void Post(Automobile automobile)
        {
        }

    }
}
