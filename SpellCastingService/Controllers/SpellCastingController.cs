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
                Console.WriteLine("\nStarting Spell Casting Service, HTTP.");

                _scrollProcessor.ProcessScrolls(scrolls);

                var message = $"Successfully Processed {scrolls.Count()} scrolls.\n";
                Console.WriteLine(message);
                return Ok(message);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went amiss, {ex.Message}");
                return BadRequest(ex);
            }
        }
    }
}