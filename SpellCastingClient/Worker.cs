using BindingAccords;
using Grpc.Net.Client;
using ProtoBuf.Grpc;
using ProtoBuf.Grpc.Client;
using SpellCastingWorker;
using WizardLibrary.Factories;
using static BindingAccords.Bindings;

namespace SpellCastingClient
{
    public class Worker : BackgroundService
    {
        private readonly IScrollFactory _scrollFactory;

        public Worker(IScrollFactory scrollFactory)
        {
            _scrollFactory = scrollFactory;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var channel = GrpcChannel.ForAddress("https://localhost:7216"); //grpc://localhost:7216
                var client = channel.CreateGrpcService<ICastingService>();

                var bundledScrolls = new BundledScrolls()
                {
                    Status = CastingStatus.Unknown
                };

                var scrolls = _scrollFactory.CreateRandomScroll();
                var requestScrolls = ScrollTransmogrifier.Transmogrify(scrolls);

                bundledScrolls.Scrolls.AddRange(requestScrolls);

                var scrollGlyph = bundledScrolls.Scrolls.First().UniqueGlyph;
                Console.WriteLine($"Sending scroll with uniqueGlyph: {scrollGlyph}\n");

                await client.Cast(bundledScrolls);

                await Task.Delay(10000, stoppingToken);
            }
        }
    }
}