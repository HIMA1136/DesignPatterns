# Composite Pattern

## Usage

Composite gives individual objects and groups a shared interface. The file system example lets a folder contain files and other folders, then displays the tree recursively.

```csharp
var folder = new FolderItem("Documents");
folder.Add(new FileItem("notes.txt"));
folder.Display();
```

## When to use it

Use Composite when clients should treat a single item and a nested group uniformly, such as files and folders, menu trees, or UI components.
