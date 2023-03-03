namespace SpellCastingService.Models.Spells
{
    public class Compendium
    {
        public enum Arcane
        {
            MagicMissles = SpellType.Offensive,
            EnergyShield = SpellType.Defensive,
            ManaFont = SpellType.Resource
        }

        public enum Elemental
        {
            Fireball = SpellType.Offensive,
            Iceblock = SpellType.Defensive,
            StaticCharge = SpellType.Resource
        }

        public enum BloodRitual
        {
            SoulScythe = SpellType.Offensive,
            BoneArmor = SpellType.Defensive,
            LeachEssence = SpellType.Resource
        }
    }
}
