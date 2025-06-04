# GitHub Copilot Instructions

This repository contains a C# Blazor WebAssembly project targeting .NET 8, developed using Visual Studio 2022.

## Coding Guidelines

- **Framework:** Use Blazor WebAssembly with .NET 8 APIs and features.
- **Language:** All code should be written in C# unless otherwise specified.
- **Component Structure:** Prefer Razor components (`.razor` files) for UI. Use partial classes for code-behind logic when needed.
- **Naming Conventions:** Follow standard C# naming conventions (PascalCase for classes, camelCase for variables and parameters).
- **Async Programming:** Use `async`/`await` for asynchronous operations.
- **Dependency Injection:** Use Blazor's built-in dependency injection for services.
- **State Management:** Prefer built-in Blazor state management patterns (e.g., cascading parameters, DI services).

## Prefer C# 12 and 13 Language Features

### Primary Constructors
Use primary constructors to simplify your class and struct definitions.

```csharp
public class Person(string name, int age) {
    public void Deconstruct(out string name, out int age) => (name, age) = (this.name, this.age);
}
```

### Collection Expressions
Use collection expressions for concise and readable collection initialization.

```csharp
int[] numbers = [1, 2, 3, 4, 5];
List<string> words = ["one", "two", "three"];
```

### Default Lambda Parameters
Define default values for parameters on lambda expressions.

```csharp
Func<int, int, int> add = (x, y = 5) => x + y;
Console.WriteLine(add(3)); // Output: 8
```

### ref readonly Parameters
Use `ref readonly` parameters to improve API clarity.

```csharp
void ProcessData(ref readonly int data) {
    // Use data without modifying it
}
```

### Alias Any Type
Use the `using` alias directive to create semantic aliases for complex types.

```csharp
using IntPair = (int first, int second);
IntPair pair = (1, 2);
```

### Inline Arrays
Use inline arrays for performance-sensitive scenarios in structs.

```csharp
[System.Runtime.CompilerServices.InlineArray(10)]
public struct Buffer {
    private int _element0;
}
```

### params Collections
Utilize `params` collections to simplify method parameter definitions.

```csharp
public void Concat<T>(params ReadOnlySpan<T> items) {
    for (int i = 0; i < items.Length; i++) {
        Console.Write(items[i]);
        Console.Write(" ");
    }
    Console.WriteLine();
}
```

### New Lock Object
Use the `System.Threading.Lock` type for improved thread synchronization.

```csharp
var myLock = new Lock();
using (myLock.EnterScope()) {
    // Critical section
}
```

### New Escape Sequence
Use `\e` as a character literal escape sequence for the ESCAPE character.

```csharp
char escapeChar = '\e';
```

### Method Group Natural Type
Optimize method overload resolution using method group natural type improvements.

```csharp
var printAction = (string s) => Console.WriteLine(s);
printAction("Hello, C# 13!");
```

### Implicit Index Access
Use the `^` operator in object initializers for implicit "from the end" indexing.

```csharp
public class TimerRemaining {
    public int[] buffer { get; set; } = new int[10];
}
var countdown = new TimerRemaining() {
    buffer = { [^1] = 0, [^2] = 1, [^3] = 2, [^4] = 3, [^5] = 4 }
};
```

### ref and Unsafe in Iterators and Async Methods
Allow `ref` local variables and unsafe contexts in iterator and async methods.

```csharp
async Task ProcessDataAsync() {
    ref int localRef = ref someRefVariable;
    await Task.Delay(1000);
    // Usage of localRef within the same scope
}
```

### Partial Properties and Indexers
Declare partial properties and indexers for more modular code.

```csharp
public partial class MyClass {
    public partial string Name { get; set; }
}
public partial class MyClass {
    private string _name;
    public partial string Name {
        get => _name;
        set => _name = value;
    }
}
```

### Overload Resolution Priority
Use the `OverloadResolutionPriorityAttribute` to prioritize method overloads.

```csharp
public class MyClass {
    [OverloadResolutionPriority(1)]
    public void Method(int a) { }

    [OverloadResolutionPriority(2)]
    public void Method(int a, int b) { }
}
```

## File Organization

- Place UI components in the `Components` folder.
- Place services in the `Services` folder.
- Place shared models in the `Shared` folder.
- Static assets (CSS, JS, images) should go in the `wwwroot` folder.

## Best Practices

- Write reusable and modular components.
- Use strongly-typed parameters for components.
- Validate user input and handle exceptions gracefully.
- Write XML documentation for public classes and methods.
- Prefer minimal JavaScript interop; use C# and Blazor features when possible.

## Testing

- Add unit tests for services and business logic.
- Use bUnit or similar frameworks for component testing.

## Pull Requests

- Ensure all code builds and passes tests before submitting a pull request.
- Follow the repository’s code review and contribution guidelines.

---
_These instructions help GitHub Copilot generate code that matches the project's standards and structure._