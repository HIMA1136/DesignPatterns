# Template Method Pattern

## Usage

Template Method defines the fixed steps of an algorithm in a base class and lets subclasses customize selected steps. The CV report generator shares its workflow while PDF, Excel, and photo report generators provide format-specific behavior.

```csharp
CVReportGenerator generator = new PdfCVReportGenerator();
generator.Generate();
```

## When to use it

Use Template Method when several implementations follow the same overall process but differ in a few steps. It keeps the process consistent and avoids duplicating the shared workflow.
