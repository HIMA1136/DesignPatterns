# Flyweight Pattern

## Usage

Flyweight shares immutable data across many objects and keeps per-instance data outside the shared object. The tree example shares each tree type's name and color while each tree keeps its own coordinates.

```csharp
var oakType = TreeFactory.Get("Oak", "Green");
oakType.Display(2, 4);
```

## When to use it

Use Flyweight when an application creates many similar objects and profiling shows that repeated shared state consumes significant memory.
