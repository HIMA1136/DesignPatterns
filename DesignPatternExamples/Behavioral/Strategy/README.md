# Strategy Pattern

## Usage

Strategy packages interchangeable algorithms behind a shared interface. This example selects pricing and checkout strategies, then passes them to products or a checkout processor.

```csharp
var product = new Product("Phone", 1000, new DiscountPricingStrategy());
var checkout = new CheckoutProcessor(new CashOnDeliveryStrategy());
checkout.Process(product);
```

## When to use it

Use Strategy when an operation has several valid algorithms and the choice may vary by context or at runtime. It avoids large conditionals and makes each algorithm independently replaceable.
