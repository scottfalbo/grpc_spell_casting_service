# grpc_spell_casting_service

GRPC Server Service and Worker Client.  The worker is configured to make a GRPC call to the server every 10 seconds.  

## Running the Services

- Install the required package.
  - `dotnet tool install dotnet-grpc -g`
- Start the Server Web API service.  
- Start the Worker Service.

Once both services are running you can watch their interaction in the console windows.

## Call Server Using Postman

- Run the Web API Service. No need to run the Worker Service.

### REST HTTP Call

- For a regular REST HTTP call use the following request url:
  - `https://localhost:xxxx/spellcasting/cast`
- Use the following schema for the request body.

```json
[
    {
        "uniqueGlyph": "001",
        "magicPhrase": "shaboomy",
        "magicType": 0,
        "spellType": 0
    },
        {
        "uniqueGlyph": "002",
        "magicPhrase": "shaboomy",
        "magicType": 1,
        "spellType": 1
    }
]
```

### GRPC Call

- For a gRPC call in Postman create a new gRPC request, use the following url:
  - `grpc://localhost:xxxx`
- Use the following schema for the request body.

```json
{
    "Scrolls": [
        {
            "UniqueGlyph": "001",
            "CastingPhrase": "shaboomy",
            "MagicType": 1,
            "SpellType": 1
        },
        {
            "UniqueGlyph": "002",
            "CastingPhrase": "shaboomy",
            "MagicType": 0,
            "SpellType": 1
        }
    ]
}
```

| MagicType | SpellType | Resulting Spell |
|-----------|-----------|-----------------|
|0          |1          |Magic Missiles    |
|0          |2          |Energy Shield    |
|0          |3          |Mana Font        |
|1          |1          |Fireball         |
|1          |2          |Ice Block        |
|1          |3          |Static Charge    |
|2          |1          |Spectral Scythe  |
|2          |2          |Bone Armor       |
|2          |3          |Siphon Soul      |

## Resources
- https://app.pluralsight.com/library/courses/aspdotnet-core-6-using-grpc/table-of-contents
- https://learn.microsoft.com/en-us/aspnet/core/grpc/?view=aspnetcore-6.0