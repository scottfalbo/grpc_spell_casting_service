namespace SpellCastingService.Models.Spells
{
    public abstract class Spell
    {
        public string UniqueGlyph { get; set; }
        public string Name { get; set; }
        public MagicType MagicType { get; set; }
        public SpellType SpellType { get; set; }
        public string Description { get; set; }
    }
}
