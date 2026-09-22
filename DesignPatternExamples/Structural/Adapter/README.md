# Adapter Pattern

## Usage

Adapter converts one interface into another expected by the client. `PaymentAdapter` wraps the legacy gateway and exposes its API as `IModernPayment`.

```csharp
IModernPayment payment = new PaymentAdapter(new LegacyPaymentGateway());
payment.Pay(42.50m);
```

## When to use it

Use Adapter when integrating existing or third-party code whose interface does not match the one your application expects.
