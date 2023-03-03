namespace SpellCastingService.Models.Spells
{
    public abstract class Spell
    {
        public string UniqueGlyph { get; set; }
        public string Name { get; set; }
        public MagicType MagicType { get; set; }
        public SpellType SpellType { get; set; }
        public string Description { get; set; }

        public string ScryeCompendiumNames((MagicType, SpellType) magicSpellType)
        {
            return magicSpellType switch
            {
                (MagicType.Arcane, SpellType.Offensive) => Compendium.Name.Arcane.Offensive,
                (MagicType.Arcane, SpellType.Defensive) => Compendium.Name.Arcane.Defensive,
                (MagicType.Arcane, SpellType.Resource) => Compendium.Name.Arcane.Resource,

                (MagicType.Elemental, SpellType.Offensive) => Compendium.Name.Elemental.Offensive,
                (MagicType.Elemental, SpellType.Defensive) => Compendium.Name.Elemental.Defensive,
                (MagicType.Elemental, SpellType.Resource) => Compendium.Name.Arcane.Resource,

                (MagicType.BloodRitual, SpellType.Offensive) => Compendium.Name.Arcane.Offensive,
                (MagicType.BloodRitual, SpellType.Defensive) => Compendium.Name.Arcane.Defensive,
                (MagicType.BloodRitual, SpellType.Resource) => Compendium.Name.Arcane.Resource,

                _ => "Nameless",
            };
        }

        public string ScryeCompendiumDescriptions((MagicType, SpellType) magicSpellType)
        {
            return magicSpellType switch
            {
                (MagicType.Arcane, SpellType.Offensive) => Compendium.Description.Arcane.Offensive,
                (MagicType.Arcane, SpellType.Defensive) => Compendium.Description.Arcane.Defensive,
                (MagicType.Arcane, SpellType.Resource) => Compendium.Description.Arcane.Resource,

                (MagicType.Elemental, SpellType.Offensive) => Compendium.Description.Elemental.Offensive,
                (MagicType.Elemental, SpellType.Defensive) => Compendium.Description.Elemental.Defensive,
                (MagicType.Elemental, SpellType.Resource) => Compendium.Description.Arcane.Resource,

                (MagicType.BloodRitual, SpellType.Offensive) => Compendium.Description.Arcane.Offensive,
                (MagicType.BloodRitual, SpellType.Defensive) => Compendium.Description.Arcane.Defensive,
                (MagicType.BloodRitual, SpellType.Resource) => Compendium.Description.Arcane.Resource,

                _ => "nothing happened",
            };
        }
    }
}
