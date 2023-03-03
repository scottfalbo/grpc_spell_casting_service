using Google.Protobuf;
using Grpc.Core;
using SpellCastingService.gRPC;
using SpellCastingService.Models;
using SpellCastingService.Processors;
using static SpellCastingService.gRPC.SpellCastingProto;

namespace SpellCastingService.Services
{
    public class GrpcCastingService : SpellCastingProtoBase
    {
        private readonly IScrollProcessor _scrollProcessor;

        public GrpcCastingService(IScrollProcessor scrollProcessor)
        {
            _scrollProcessor = scrollProcessor;
        }

        public async override Task<ResponseStatus> Cast(BundledScrolls request, ServerCallContext context)
        {
            var scrolls = UnbundleScrolls(request);

            var responseStatus = new ResponseStatus()
            {
                Status = request.Status
            };

            try
            {
                Console.WriteLine("Starting Spell Casting Service.");

                _scrollProcessor.ProcessScrolls(scrolls);

                Console.WriteLine($"Successfully Processed {scrolls.Count()} scrolls.");
                return responseStatus;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went amiss, {ex.Message}");
                return responseStatus;
            }
        }

        private static List<Scroll> UnbundleScrolls(BundledScrolls bundledScrolls)
        {
            var scrolls = new List<Scroll>();

            foreach (var scroll in bundledScrolls.Scrolls)
            {
                var newScroll = new Scroll()
                {
                    UniqueGlyph = scroll.UniqueGlyph,
                    CastingPhrase = scroll.CastingPhrase,
                    MagicType = (MagicType)scroll.MagicType,
                    SpellType = (SpellType)scroll.SpellType
                };

                scrolls.Add(newScroll);
            }

            return scrolls;
        }
    }
}
