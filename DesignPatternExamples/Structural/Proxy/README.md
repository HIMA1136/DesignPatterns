# Proxy Pattern

## Usage

Proxy implements the same interface as a real object and controls access to it. The protected image proxy checks permission before loading and displaying the image.

```csharp
IImage image = new ProtectedImageProxy("confidential.png", hasAccess: true);
image.Display();
```

## When to use it

Use Proxy when access to an object needs control or extra handling, such as authorization, lazy loading, caching, logging, or remote access.
