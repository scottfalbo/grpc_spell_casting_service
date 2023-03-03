using SpellCastingService.Models.Spells;

namespace SpellCastingService.Publishers
{
    public interface IResourceCaster
    {
        void Cast(Spell spell);
    }
}
