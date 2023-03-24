using BindingAccords;
using ProtoBuf.Grpc;
using SpellCastingService.Models;
using SpellCastingService.Processors;
using static BindingAccords.Bindings;

namespace SpellCastingService.Services
{
    public class GrpcCastingService : ICastingService
    {
        private readonly IScrollProcessor _scrollProcessor;

        public GrpcCastingService(IScrollProcessor scrollProcessor)
        {
            _scrollProcessor = scrollProcessor;
        }

        public Task<ResponseStatus> Cast(BundledScrolls request, CallContext context)
        {
            var scrolls = UnbundleScrolls(request);

            var responseStatus = new ResponseStatus()
            {
                Status = request.Status
            };

            try
            {
                Console.WriteLine("\nStarting Spell Casting Service, gRPC.");

                _scrollProcessor.ProcessScrolls(scrolls);

                var message = $"Successfully Processed {scrolls.Count} scrolls.\n";
                Console.WriteLine(message);

                responseStatus.Message = message;
                return Task.FromResult(responseStatus);
            }
            catch (Exception ex)
            {
                var message = $"Something went amiss, {ex.Message}";
                Console.WriteLine(message);

                responseStatus.Message = message;
                return Task.FromResult(responseStatus);
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
