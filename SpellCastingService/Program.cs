using SpellCastingService.Factories;
using SpellCastingService.Processors;
using SpellCastingService.Publishers;
using SpellCastingService.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddGrpc();

builder.Services.AddTransient<IScrollProcessor, ScrollProcessor>();
builder.Services.AddTransient<ISpellFactory, SpellFactory>();
builder.Services.AddTransient<IOffensiveCaster, OffensiveCaster>();
builder.Services.AddTransient<IDefensiveCaster, DefensiveCaster>();
builder.Services.AddTransient<IResourceCaster, ResourceCaster>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapGrpcService<GrpcCastingService>();

app.Run();
