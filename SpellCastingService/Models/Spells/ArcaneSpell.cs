namespace SpellCastingService.Models.Spells
{
    public class ArcaneSpell : Spell
    {
        public ArcaneSpell(Scroll scroll) 
        {
            Name = ScryeCompendium((scroll.MagicType, scroll.SpellType));
            UniqueGlyph = scroll.UniqueGlyph;
            MagicType = scroll.MagicType;
            SpellType = scroll.SpellType;
            Description = "";
        }
    }
}