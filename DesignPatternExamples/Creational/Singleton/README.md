# Singleton Pattern

## Usage

Singleton provides one shared instance through a public access point. `AppSettings` uses `Lazy<T>` so the instance is created once, on first access, and safely shared across threads.

```csharp
var settings = AppSettings.Instance;
Console.WriteLine(settings.ApplicationName);
```

## When to use it

Use Singleton only when the application truly requires one shared instance, such as a process-wide configuration provider. Consider dependency injection instead when it can provide the required lifetime more clearly; global state can make code harder to test and reason about.
