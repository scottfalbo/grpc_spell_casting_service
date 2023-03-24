using SpellCastingService.Models;
using static BindingAccords.Bindings;

namespace SpellCastingWorker
{
    internal static class ScrollTransmogrifier
    {
        public static List<RequestScroll> Transmogrify(List<Scroll> scrolls)
        {
            var requestScrolls = new List<RequestScroll>();

            foreach (var scroll in scrolls)
            {
                var requestScroll = new RequestScroll()
                {
                    UniqueGlyph = scroll.UniqueGlyph,
                    CastingPhrase = scroll.CastingPhrase,
                    MagicType = (int)scroll.MagicType,
                    SpellType = (int)scroll.SpellType
                };

                requestScrolls.Add(requestScroll);
            }

            return requestScrolls;
        }
    }
}
