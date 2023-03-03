using SpellCastingService.Models;

namespace SpellCastingService.Processors
{
    public interface IScrollProcessor
    {
        void ProcessScrolls(IEnumerable<Scroll> scrolls);
    }
}
