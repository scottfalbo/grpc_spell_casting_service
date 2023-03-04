using Grpc.Net.Client;
using SpellCastingService.gRPC;
using SpellCastingService.Models;
using static SpellCastingService.gRPC.SpellCastingProto;

namespace SpellCastingClientUI.Clients
{
    public class GrpcSpellClient : IGrpcSpellClient
    {
        public ResponseStatus CastSpell(List<Scroll> scrolls)
        {
            var requestScrolls = ConvertScrolls(scrolls);

            var channel = GrpcChannel.ForAddress("https://localhost:7216"); //grpc://localhost:7216
            //var client = new SpellCastingProtoClient(channel);

            return null;
        }

        private static List<RequestScroll> ConvertScrolls(List<Scroll> scrolls)
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
