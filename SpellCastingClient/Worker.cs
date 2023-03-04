using Grpc.Net.Client;
using SpellCastingService.gRPC;
using SpellCastingWorker;
using WizardLibrary.Factories;
using static SpellCastingService.gRPC.SpellCastingProto;

namespace SpellCastingClient
{
    public class Worker : BackgroundService
    {
        private readonly IScrollFactory _scrollFactory;
        private readonly Random _random;

        public Worker(IScrollFactory scrollFactory)
        {
            _random = new();
            _scrollFactory = scrollFactory;
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

                var scrolls = _scrollFactory.CreateRandomScroll();
                var requestScrolls = ScrollTransmogrifier.Transmogrify(scrolls);

                bundledScrolls.Scrolls.AddRange(requestScrolls);

                var scrollGlyph = bundledScrolls.Scrolls.First().UniqueGlyph;
                Console.WriteLine($"Sending scroll with uniqueGlyph: {scrollGlyph}\n");

                client.Cast(bundledScrolls);

                await Task.Delay(10000, stoppingToken);
            }
        }
    }
}