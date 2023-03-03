using Microsoft.AspNetCore.Authorization;
using SpellCastingService.Factories;
using SpellCastingService.Models;
using SpellCastingService.Models.Spells;
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
            
            foreach (var scroll in scrolls)
            {
                var spell = _spellFactory.CraftSpell(scroll);

                CastSpell(spell);
            }
        }

        private void CastSpell(Spell spell)
        {
            switch(spell.SpellType)
            {
                case SpellType.Offensive:
                    _offensiveCaster.Cast(spell);
                    break;

                case SpellType.Defensive:
                    _defensiveCaster.Cast(spell);
                    break;

                case SpellType.Resource:
                    _resourceCaster.Cast(spell);
                    break;

                default:
                    Console.WriteLine("The scroll is undefined and fizzles.");
                    break;
            }
        }
    }
}
