# Visitor Pattern

## Usage

Visitor separates operations from the object structure they operate on. The file and folder elements accept visitors such as size calculation or report generation.

```csharp
IVisitor visitor = new SizeVisitor();
root.Accept(visitor);
```

## When to use it

Use Visitor when you need to add several operations to a relatively stable set of element types. It keeps those operations out of the element classes; adding new element types can require updates to visitors.
