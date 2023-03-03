using Microsoft.AspNetCore.Mvc;
using SpellCastingService.Models;

namespace SpellCastingService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpellCastingController : ControllerBase
    {
        [Route("castspell/{spellName}")]
        [HttpGet]
        public IActionResult Cast([FromBody] IEnumerable<Scroll> scrolls)
        {
            // call processor with scroll
            return Ok();
        }
    }
}