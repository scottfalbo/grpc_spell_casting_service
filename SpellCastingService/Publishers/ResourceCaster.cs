using SpellCastingService.Models.Spells;

namespace SpellCastingService.Publishers
{
    public class ResourceCaster : IResourceCaster
    {
        public void Cast(Spell spell)
        {
            Console.WriteLine($"{nameof(ResourceCaster)} has been evoked.");
            Console.WriteLine($"Casting {spell.Name}, {spell.Description}");
        }
    }
}
