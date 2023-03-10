using WizardLibrary.Factories;

namespace SpellCastingClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHost host = Host.CreateDefaultBuilder(args)
                .ConfigureServices(services =>
                {
                    services.AddHostedService<Worker>();
                    services.AddTransient<IScrollFactory, ScrollFactory>();
                })
                .Build();

            host.Run();
        }
    }
}