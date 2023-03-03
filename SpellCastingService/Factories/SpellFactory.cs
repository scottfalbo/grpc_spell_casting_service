using SpellCastingService.Models;
using SpellCastingService.Models.Spells;

namespace SpellCastingService.Factories
{
    public class SpellFactory : ISpellFactory
    {
        public Spell CraftSpell(Scroll scroll)
        {
            Console.WriteLine($"{nameof(SpellFactory)} scribing scroll with glyph: {scroll.UniqueGlyph}");

            return scroll.MagicType switch
            {
                MagicType.Arcane => new ArcaneSpell(scroll),
                MagicType.Elemental => new ElementalSpell(scroll),
                MagicType.BloodRitual => new BloodRitualSpell(scroll),
                _ => null,
            };
        }
    }
}
