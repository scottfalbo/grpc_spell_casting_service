using SpellCastingService.Models.Spells;

namespace SpellCastingService.Publishers
{
    public interface IDefensiveCaster
    {
        void Evoke(Spell spell);
    }
}
