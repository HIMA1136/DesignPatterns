# Iterator Pattern

## Usage

Iterator provides a way to visit items in a collection one at a time without exposing how that collection stores them. In this example, an `EmployeeIterator` traverses the employees held by an HR collection.

```csharp
var iterator = department.CreateIterator();
while (iterator.HasNext())
    Console.WriteLine(iterator.Next().Name);
```

## When to use it

Use Iterator when callers need a consistent way to traverse a collection, or when you want to support multiple traversal strategies without exposing the collection's internal representation.
