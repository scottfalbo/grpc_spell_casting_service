using SpellCastingService.Models.Spells;

namespace SpellCastingService.Publishers
{
    public class DefensiveCaster : IDefensiveCaster
    {
        public void Evoke(Spell spell)
        {
            Console.WriteLine($"{nameof(DefensiveCaster)} has been evoked.");
            spell.Cast();
        }
    }
}
