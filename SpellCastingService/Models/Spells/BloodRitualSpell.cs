namespace SpellCastingService.Models.Spells
{
    public class BloodRitualSpell : Spell
    {
        public BloodRitualSpell(Scroll scroll)
        {
            var magicSpellType = (scroll.MagicType, scroll.SpellType);

            Name = ScryeCompendiumNames(magicSpellType);
            UniqueGlyph = scroll.UniqueGlyph;
            MagicType = scroll.MagicType;
            SpellType = scroll.SpellType;
            Description = ScryeCompendiumDescriptions(magicSpellType);
        }
    }
}
