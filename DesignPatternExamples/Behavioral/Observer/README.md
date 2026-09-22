# Observer Pattern

## Usage

Observer lets subscribers register for events from a publisher. The marketplace example publishes event types such as a new product or price drop to subscribed customers and sellers.

```csharp
events.Subscribe(MarketplaceEvent.PriceDrop, customer);
events.Publish(MarketplaceEvent.PriceDrop, "TV price dropped");
```

## When to use it

Use Observer when one change should notify an unknown or changing set of listeners, such as UI events, notifications, or domain events. It keeps the publisher independent of concrete subscribers.
