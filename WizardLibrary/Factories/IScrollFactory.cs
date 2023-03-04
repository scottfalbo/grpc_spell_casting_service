using SpellCastingService.Models;

namespace WizardLibrary.Factories
{
    public interface IScrollFactory
    {
        List<Scroll> CreateRandomScroll();
    }
}
