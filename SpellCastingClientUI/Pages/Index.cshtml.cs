using Grpc.Net.Client;
using SpellCastingService.gRPC;
using static SpellCastingService.gRPC.SpellCastingProto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SpellCastingClientUI.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {

        }

        public void OnGet()
        {
            //var channel = GrpcChannel.ForAddress("https://localhost:7216"); //grpc://localhost:7216
            //var client = new SpellCastingProtoClient(channel);


            //client.Cast(bundledScrolls);
        }
    }
}