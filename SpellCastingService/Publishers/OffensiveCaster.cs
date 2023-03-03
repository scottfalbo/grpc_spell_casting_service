using SpellCastingService.Models.Spells;

namespace SpellCastingService.Publishers
{
    public class OffensiveCaster : IOffensiveCaster
    {
        public void Evoke(Spell spell)
        {
            Console.WriteLine($"{nameof(OffensiveCaster)} has been evoked.");
            spell.Cast();
        }
    }
}
