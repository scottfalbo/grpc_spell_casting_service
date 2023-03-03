using SpellCastingService.Models.Spells;

namespace SpellCastingService.Publishers
{
    public class ResourceCaster : IResourceCaster
    {
        public void Evoke(Spell spell)
        {
            Console.WriteLine($"{nameof(ResourceCaster)} has been evoked.");
            spell.Cast();
        }
    }
}
