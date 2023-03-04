using Grpc.Net.Client;
using static SpellCastingService.gRPC.SpellCastingProto;

namespace SpellCastingClient
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;

        public Worker(ILogger<Worker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                var channel = GrpcChannel.ForAddress("https://localhost:7216"); //grpc://localhost:7216
                var client = new SpellCastingProtoClient(channel);

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}