using Grpc.Net.Client;
using SpellCastingService.gRPC;
using static SpellCastingService.gRPC.SpellCastingProto;

namespace SpellCastingClient
{
    public class Worker : BackgroundService
    {
        private readonly Random _random;

        public Worker()
        {
            _random = new();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var channel = GrpcChannel.ForAddress("https://localhost:7216"); //grpc://localhost:7216
                var client = new SpellCastingProtoClient(channel);

                var bundledScrolls = new BundledScrolls()
                {
                    Status = CastingStatus.Unknown,
                };

                bundledScrolls.Scrolls.AddRange(CreateRandomScroll());

                var scrollGlyph = bundledScrolls.Scrolls.First().UniqueGlyph;
                Console.WriteLine($"Sending scroll with uniqueGlyph: {scrollGlyph}\n");

                client.Cast(bundledScrolls);

                await Task.Delay(10000, stoppingToken);
            }
        }

        private List<RequestScroll> CreateRandomScroll()
        {
            return new List<RequestScroll>()
            {
                new RequestScroll()
                {
                    UniqueGlyph = Guid.NewGuid().ToString(),
                    CastingPhrase = "sha zam",
                    MagicType = _random.Next(3),
                    SpellType = _random.Next(3)
                }
            };
        }
    }
}