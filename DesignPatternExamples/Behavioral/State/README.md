# State Pattern

## Usage

State represents an object's current condition as a separate state object. The order context delegates actions to states such as Created, Paid, Shipped, Delivered, or Cancelled.

```csharp
var order = new OrderContext();
order.Pay();
order.Ship();
```

## When to use it

Use State when behavior depends on an object's current state and conditional logic is growing. Each state can define valid actions and transitions for that condition.
