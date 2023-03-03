using Microsoft.AspNetCore.Mvc;
using SpellCastingService.Models;
using SpellCastingService.Processors;

namespace SpellCastingService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SpellCastingController : ControllerBase
    {
        private readonly IScrollProcessor _scrollProcessor;

        public SpellCastingController(IScrollProcessor scrollProcessor) 
        {
            _scrollProcessor = scrollProcessor;
        }

        [HttpGet]
        public string Get() => "Spell Casting Service Running";

        [Route("cast")]
        [HttpPost]
        public IActionResult Cast([FromBody] IEnumerable<Scroll> scrolls)
        {
            try
            {
                Console.WriteLine("Starting Spell Casting Service.");

                _scrollProcessor.ProcessScrolls(scrolls);

                Console.WriteLine($"Successfully Processed {scrolls.Count()} scrolls.");
                return Ok();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went amiss, {ex.Message}");
                return BadRequest(ex);
            }
            
        }
    }
}