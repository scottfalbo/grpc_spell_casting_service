using SpellCastingService.Models;
using SpellCastingService.Models.Spells;

namespace SpellCastingService.Factories
{
    public interface ISpellFactory
    {
        Spell CraftSpell(Scroll scroll);
    }
}
