using SpellCastingService.Models;
using SpellCastingService.Models.Spells;

namespace SpellCastingService.Factories
{
    public class SpellFactory : ISpellFactory
    {
        public Spell CraftSpell(Scroll scroll)
        {
            return new ArcaneSpell(scroll);
        }
    }
}
