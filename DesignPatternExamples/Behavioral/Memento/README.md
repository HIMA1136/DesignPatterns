# Memento Pattern

## Usage

Memento captures an object's state so it can be restored later without exposing the object's internals. The text editor example saves snapshots and lets a history manager restore them.

```csharp
history.Save(editor.CreateSnapshot());
editor.Type(" more text");
editor.Restore(history.Undo());
```

## When to use it

Use Memento for undo/redo, checkpoints, or rollback when an object's state must be saved and restored while its encapsulation remains intact.
