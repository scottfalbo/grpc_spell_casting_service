using Grpc.Net.Client;
using SpellCastingService.gRPC;
using static SpellCastingService.gRPC.SpellCastingProto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SpellCastingClientUI.Clients;
using System;

namespace SpellCastingClientUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHttpSpellClient _httpClient;
        private readonly IGrpcSpellClient _grpcClient;
        private readonly Random _random;

        public IndexModel(IHttpSpellClient httpClient, IGrpcSpellClient grpcClient)
        {
            _httpClient = httpClient;
            _grpcClient = grpcClient;
            _random = new();
        }

        public void OnGet()
        {
            //var channel = GrpcChannel.ForAddress("https://localhost:7216"); //grpc://localhost:7216
            //var client = new SpellCastingProtoClient(channel);


            //client.Cast(bundledScrolls);
        }
    }
}