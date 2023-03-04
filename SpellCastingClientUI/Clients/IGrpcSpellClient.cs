using SpellCastingService.gRPC;
using SpellCastingService.Models;

namespace SpellCastingClientUI.Clients
{
    public interface IGrpcSpellClient
    {
        ResponseStatus CastSpell(List<Scroll> scrolls);
    }
}
