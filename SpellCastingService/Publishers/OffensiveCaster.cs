using SpellCastingService.Models.Spells;

namespace SpellCastingService.Publishers
{
    public class OffensiveCaster : IOffensiveCaster
    {
        public void Cast(Spell spell)
        {
            Console.WriteLine($"{nameof(OffensiveCaster)} has been evoked.");
            Console.WriteLine($"Casting {spell.Name}, {spell.Description}");
        }
    }
}
