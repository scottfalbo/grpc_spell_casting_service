namespace SpellCastingService.Models
{
    public class Scroll
    {
        public string UniqueGlyph { get; set; }
        public string CastingPhrase { get; set; }
        public MagicType MagicType { get; set; }
        public SpellType SpellType { get; set; }
    }
}
