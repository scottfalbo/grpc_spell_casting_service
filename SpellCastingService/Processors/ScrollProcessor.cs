using SpellCastingService.Factories;
using SpellCastingService.Models;
using SpellCastingService.Publishers;

namespace SpellCastingService.Processors
{
    public class ScrollProcessor : IScrollProcessor
    {
        private readonly ISpellFactory _spellFactory;
        private readonly IOffensiveCaster _offensiveCaster;
        private readonly IDefensiveCaster _defensiveCaster;
        private readonly IResourceCaster _resourceCaster;

        public ScrollProcessor(
            ISpellFactory spellFactory, 
            IOffensiveCaster offensiveCaster,
            IDefensiveCaster defensiveCaster, 
            IResourceCaster resourceCaster)
        {
            _spellFactory = spellFactory;
            _offensiveCaster = offensiveCaster;
            _defensiveCaster = defensiveCaster;
            _resourceCaster = resourceCaster;
        }

        public void ProcessScrolls(IEnumerable<Scroll> scrolls)
        {
            Console.WriteLine($"{nameof(ScrollProcessor)} received {scrolls.Count()} scrolls for processing");
            

        }
    }
}
