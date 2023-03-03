using SpellCastingService.Models.Spells;

namespace SpellCastingService.Publishers
{
    public interface IOffensiveCaster
    {
        void Cast(Spell spell);
    }
}
