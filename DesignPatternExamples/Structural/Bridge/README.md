# Bridge Pattern

## Usage

Bridge separates an abstraction from its implementation so both can vary independently. Here, a `Remote` works with any `IDevice`, including a television or radio.

```csharp
var remote = new Remote(new Television());
remote.SelectChannel(7);
```

## When to use it

Use Bridge when two dimensions of a design need to evolve independently, such as controls and devices or reports and output formats. It prevents a subclass for every combination.
