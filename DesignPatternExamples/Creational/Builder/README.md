# Builder Pattern

## Usage

Builder constructs a complex object step by step. The computer example lets callers specify required parts and optional features, then validates and creates the computer with `Build()`.

```csharp
var computer = new ComputerBuilder()
    .WithCpu("8-core CPU")
    .WithMemory(32)
    .WithGraphicsCard("Dedicated GPU")
    .Build();
```

## When to use it

Use Builder when an object has many configuration options, especially when some are optional or construction needs validation. It makes object creation readable without a long list of constructor arguments.
