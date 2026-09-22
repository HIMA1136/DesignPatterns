# Decorator Pattern

## Usage

Decorator wraps an object with another object that implements the same interface, adding behavior without changing the original class. The coffee example adds milk and its cost around a base coffee.

```csharp
ICoffee coffee = new MilkDecorator(new HouseCoffee());
Console.WriteLine(coffee.Cost);
```

## When to use it

Use Decorator when optional features should be combinable at runtime and subclass combinations would become unwieldy.
