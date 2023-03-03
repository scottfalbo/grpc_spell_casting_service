namespace SpellCastingService.Models.Spells
{
    public abstract class Spell
    {
        public string UniqueGlyph { get; set; }
        public string Name { get; set; }
        public MagicType MagicType { get; set; }
        public SpellType SpellType { get; set; }
        public string Description { get; set; }

        public string ScryeCompendium((MagicType, SpellType) magicSpellType)
        {
            return magicSpellType switch
            {
                (MagicType.Arcane, SpellType.Offensive) => Compendium.Arcane.Offensive,
                (MagicType.Arcane, SpellType.Defensive) => Compendium.Arcane.Defensive,
                (MagicType.Arcane, SpellType.Resource) => Compendium.Arcane.Resource,

                (MagicType.Elemental, SpellType.Offensive) => Compendium.Elemental.Offensive,
                (MagicType.Elemental, SpellType.Defensive) => Compendium.Elemental.Defensive,
                (MagicType.Elemental, SpellType.Resource) => Compendium.Elemental.Resource,

                (MagicType.BloodRitual, SpellType.Offensive) => Compendium.BloodRitual.Offensive,
                (MagicType.BloodRitual, SpellType.Defensive) => Compendium.BloodRitual.Defensive,
                (MagicType.BloodRitual, SpellType.Resource) => Compendium.BloodRitual.Resource,

                _ => "Nameless",
            };
        }
    }
}
