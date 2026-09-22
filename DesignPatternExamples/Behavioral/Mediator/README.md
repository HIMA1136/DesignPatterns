# Mediator Pattern

## Usage

Mediator routes requests between colleagues so they do not need direct references to one another. This project uses requests and handlers to keep order operations separate from the mediator that dispatches them.

```csharp
var mediator = new SimpleMediator();
var orderId = await mediator.Send(new CreateOrderCommand(/* order data */));
```

## When to use it

Use Mediator when many objects communicate with one another and their dependencies are becoming tangled. It centralizes coordination while keeping each participant focused on its own work.
