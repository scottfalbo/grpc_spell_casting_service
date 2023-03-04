using Grpc.Net.Client;
using SpellCastingService.gRPC;
using WizardLibrary.Factories;
using static SpellCastingService.gRPC.SpellCastingProto;

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
                var client = new SpellCastingProtoClient(channel);

                var bundledScrolls = new BundledScrolls()
                {
                    Status = CastingStatus.Unknown
                };

                await Task.Delay(10000, stoppingToken);
            }
        }
    }
}