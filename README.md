# grpc_spell_casting_service

`https://localhost:xxxx/spellcasting/cast`

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

`grpc://localhost:xxxx`

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

0.0: Magic Missle
0.1: Energy Shield
0.2: Mana Font

1.0: Fireball
1.1: Ice Block
1.2: Static Charge

2.0: Spectral Scythe
2.1: Bone Armor
2.2: SIphon Soul