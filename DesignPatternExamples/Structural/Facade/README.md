# Facade Pattern

## Usage

Facade offers a simple entry point to a group of services. `OrderFacade` coordinates inventory reservation, payment, and shipping behind one operation.

```csharp
new OrderFacade().PlaceOrder();
```

## When to use it

Use Facade when clients need a simpler interface to a complex subsystem or when you want to reduce direct dependencies on several subsystem classes.
