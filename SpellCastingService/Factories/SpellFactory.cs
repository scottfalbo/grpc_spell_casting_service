using SpellCastingService.Models;
using SpellCastingService.Models.Spells;

namespace SpellCastingService.Factories
{
    public class SpellFactory : ISpellFactory
    {
        public Spell CraftSpell(Scroll scroll)
        {
            switch(scroll.MagicType)
            {
                case MagicType.Arcane:

                    break;
            }

            return new ArcaneSpell(scroll);
        }
    }
}
