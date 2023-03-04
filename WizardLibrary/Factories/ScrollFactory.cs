using SpellCastingService.Models;

namespace WizardLibrary.Factories
{
    public class ScrollFactory : IScrollFactory
    {
        private readonly Random _random = new Random();

        public List<Scroll> CreateRandomScroll()
        {
            return new List<Scroll>()
            {
                new Scroll()
                {
                    UniqueGlyph = Guid.NewGuid().ToString(),
                    CastingPhrase = "sha zam",
                    MagicType = (MagicType)_random.Next(3),
                    SpellType = (SpellType)_random.Next(3)
                }
            };
        }
    }
}
