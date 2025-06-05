# GitHub Copilot Instructions

This repository contains a C# Blazor WebAssembly project targeting .NET 9, developed using Visual Studio 2022.

# GitHub Copilot Instructions for Commit Messages

- Use Conventional Commits: `<type>(<scope>): <short description>`.
  - Types: `feat`, `fix`, `docs`, `style`, `refactor`, `test`, `chore`.
  - Scopes: `blazor`, `api`, `ui`, `db`, `auth`.
  - Keep first line <72 characters.
- Include a 2-3 sentence body explaining *what* changed and *why*.
- Focus on .NET 9 and Blazor conventions (e.g., Razor, SignalR, EF Core).
- Example: `feat(blazor): add login component`
  - Created `Login.razor` with form validation. Integrated EF Core for user auth. Follows .NET 9 Blazor standards.

## Coding Guidelines

- **Target Framework:** .NET 9 (ASP.NET 9, Blazor WebAssembly 9)
- **Language:** All code should be written in C# unless otherwise specified.
- **Component Structure:** Prefer Razor components (`.razor` files) for UI. Use partial classes for code-behind logic when needed.
- **Naming Conventions:** Follow standard C# naming conventions (PascalCase for classes, camelCase for variables and parameters).
- **Async Programming:** Use `async`/`await` for asynchronous operations.
- **Dependency Injection:** Use Blazor's built-in dependency injection for services.
- **State Management:** Prefer built-in Blazor state management patterns (e.g., cascading parameters, DI services).

## UI Styling

- **CSS Framework:** Use [Zurb Foundation](https://get.foundation/) CSS for all UI components and layouts.
- **Custom Styles:** If Foundation does not provide the required styles, use custom SCSS/CSS located in the `wwwroot/css` or `wwwroot/scss` folders.
- **Responsive Design:** Ensure all layouts are responsive using Foundation's grid and utility classes, or custom CSS as needed.

## Professional Standards for ASP.NET Core / Blazor Projects

- **Accessibility:** Ensure all components are accessible (use semantic HTML, ARIA roles, keyboard navigation, and proper color contrast).
- **Security:** Validate all user input, prevent XSS/CSRF, and never expose secrets or sensitive data in client-side code.
- **Performance:** Use asynchronous APIs, lazy load components, and optimize static assets for fast load times.
- **API Communication:** Use strong-typed HttpClient injections; prefer minimal APIs in .NET for backend.
- **Testing:** Write unit, integration, and accessibility tests (bUnit, xUnit, Playwright). Test both UI and backend logic.
- **Documentation:** Maintain clear XML documentation, keep README up to date, and generate API docs (Swagger/OpenAPI).
- **Minimal JavaScript:** Use C# and Blazor features for all client-side logic unless absolutely necessary; if JS is required, use JS interop with clear separation.
- **Modern C# Patterns:** Use records for immutable data, file-scoped namespaces, nullable reference types, and concise object initialization.
- **Copilot Guidance:** Prefer generating C# code, complete XML comments, and suggest unit-testable methods. Avoid JS, CSS, or HTML suggestions unless explicitly requested.

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

- Place seperata features in the `Features` folder.
 - Features should be organized by functionality, with each feature in its own subfolder.
 - Features include CSS, Code Behind, and Razor files.
- Static assets (CSS, JS, images) should go in the `wwwroot` folder.
- Place Test Projects in a separate `tests` folder at the root of the repository.
- Place Projects in a `src` folder at the root of the repository.

<pre>
Follow this structured directory layout:
   project-root/
   ├── src/                                # Application source code
   │   ├── Main Project/
   │   │   ├── Features/                   # Features organized by functionality
   │   │   │   ├── Feature-1/              # Feature files
   │   │   │   ├── Feature-2/
   │   │   │   ├── Feature-N/
   │   │   ├── wwwroot/                    # Static assets
   │   │   │   ├── css/                    # CSS files
   │   │   │   ├── lib/                    # Libraries (e.g., Zurb Foundation)
   │   │   │   ├── sample-data/            # Sample data files
   │   ├── Sub- or Component-Project-1/    # Sub-projects or components
   │   ├── Sub- or Component-Project-2/
   │   ├── Sub- or Component-Project-N/
   ├── tests/                              # Unit and integration tests
   ├── scripts/                            # Scripts for deployment, setup, etc.
</pre>

## Best Practices

- Write reusable and modular components.
- Use strongly-typed parameters for components.
- Validate user input and handle exceptions gracefully.
- Write XML documentation for public classes and methods.
- Prefer minimal JavaScript interop; use C# and Blazor features when possible.
- Always add the line number and the filename when you reference code.

## Testing

- Add unit tests for services and business logic.
- Use bUnit or similar frameworks for component testing.

## Pull Requests

- Ensure all code builds and passes tests before submitting a pull request.
- Follow the repository’s code review and contribution guidelines.

# COPILOT EDITS OPERATIONAL GUIDELINES

## PRIME DIRECTIVE
	Avoid working on more than one file at a time.
	Multiple simultaneous edits to a file will cause corruption.
	Be chatting and teach about what you are doing while coding.

## LARGE FILE & COMPLEX CHANGE PROTOCOL

### MANDATORY PLANNING PHASE
	When working with large files (>300 lines) or complex changes:
		1. ALWAYS start by creating a detailed plan BEFORE making any edits
            2. Your plan MUST include:
                   - All functions/sections that need modification
                   - The order in which changes should be applied
                   - Dependencies between changes
                   - Estimated number of separate edits required
                
            3. Format your plan as:

## PROPOSED EDIT PLAN
	Working with: [filename]
	Total planned edits: [number]

### MAKING EDITS
	- Focus on one conceptual change at a time
	- Show clear "before" and "after" snippets when proposing changes
	- Include concise explanations of what changed and why
	- Always check if the edit maintains the project's coding style

### Edit sequence:
	1. [First specific change] - Purpose: [why]
	2. [Second specific change] - Purpose: [why]
	3. Do you approve this plan? I'll proceed with Edit [number] after your confirmation.
	4. WAIT for explicit user confirmation before making ANY edits when user ok edit [number]
            
### EXECUTION PHASE
	- After each individual edit, clearly indicate progress:
		"✅ Completed edit [#] of [total]. Ready for next edit?"
	- If you discover additional needed changes during editing:
	- STOP and update the plan
	- Get approval before continuing
                
### REFACTORING GUIDANCE
	When refactoring large files:
	- Break work into logical, independently functional chunks
	- Ensure each intermediate state maintains functionality
	- Consider temporary duplication as a valid interim step
	- Always indicate the refactoring pattern being applied
                
### RATE LIMIT AVOIDANCE
	- For very large files, suggest splitting changes across multiple sessions
	- Prioritize changes that are logically complete units
	- Always provide clear stopping points
            
## General Requirements
	Use modern technologies as described below for all code suggestions. Prioritize clean, maintainable code with appropriate comments.
            
### Accessibility
	- Ensure compliance with **WCAG 2.1** AA level minimum, AAA whenever feasible.
	- Always suggest:
	- Labels for form fields.
	- Proper **ARIA** roles and attributes.
	- Adequate color contrast.
	- Alternative texts (`alt`, `aria-label`) for media elements.
	- Semantic HTML for clear structure.
	- Tools like **Lighthouse** for audits.
        
## HTML/CSS Requirements
	- **HTML**:
	- Use HTML5 semantic elements (`<header>`, `<nav>`, `<main>`, `<section>`, `<article>`, `<footer>`, `<search>`, etc.)
	- Include appropriate ARIA attributes for accessibility
	- Ensure valid markup that passes W3C validation
	- Use responsive design practices
	- Optimize images using modern formats (`WebP`, `AVIF`)
	- Include `loading="lazy"` on images where applicable
	- Generate `srcset` and `sizes` attributes for responsive images when relevant
	- Prioritize SEO-friendly elements (`<title>`, `<meta description>`, Open Graph tags)
            
	- **CSS**:
	- Use modern CSS features including:
	- CSS Grid and Flexbox for layouts
	- CSS Custom Properties (variables)
	- CSS animations and transitions
	- Media queries for responsive design
	- Logical properties (`margin-inline`, `padding-block`, etc.)
	- Modern selectors (`:is()`, `:where()`, `:has()`)
	- Follow BEM or similar methodology for class naming
	- Use CSS nesting where appropriate
	- Include dark mode support with `prefers-color-scheme`
	- Prioritize modern, performant fonts and variable fonts for smaller file sizes
	- Use modern units (`rem`, `vh`, `vw`) instead of traditional pixels (`px`) for better responsiveness
            
## Security Considerations
	- Sanitize all user inputs thoroughly.
	- Parameterize database queries.
	- Enforce strong Content Security Policies (CSP).
	- Use CSRF protection where applicable.
	- Ensure secure cookies (`HttpOnly`, `Secure`, `SameSite=Strict`).
	- Limit privileges and enforce role-based access control.
	- Implement detailed internal logging and monitoring.
