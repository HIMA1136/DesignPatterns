# Prototype Pattern

## Usage

Prototype creates a new object by copying an existing one. The document example clones both the document and its section list, so edits to the draft do not change the original.

```csharp
var draft = original.Clone();
draft.Sections.Add("Risks");
```

## When to use it

Use Prototype when creating an object from scratch is costly or complicated, or when new instances should begin as copies of a configured template. Choose shallow or deep copying deliberately based on whether referenced data should be shared.
