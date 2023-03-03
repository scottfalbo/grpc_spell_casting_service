using SpellCastingService.Models.Spells;

namespace SpellCastingService.Publishers
{
    public class DefensiveCaster : IDefensiveCaster
    {
        public void Cast(Spell spell)
        {
            Console.WriteLine($"{nameof(DefensiveCaster)} has been evoked.");
            Console.WriteLine($"Casting {spell.Name}, {spell.Description}");
        }
    }
}
