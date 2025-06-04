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

## UI Styling

- **CSS Framework:** Use [Zurb Foundation](https://get.foundation/) CSS for all UI components and layouts.
- **Custom Styles:** If Foundation does not provide the required styles, use custom SCSS/CSS located in the `wwwroot/css` or `wwwroot/scss` folders.
- **No Bootstrap or Bulma:** Do not use Bootstrap, Bulma, or any other CSS frameworks.
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

- Place UI components in the `Components` folder.
- Place services in the `Services` folder.
- Place shared models in the `Shared` folder.
- Static assets (CSS, JS, images) should go in the `wwwroot` folder.
- Place Test Projects in a separate `tests` folder at the root of the repository.
- Place Projects in a `src` folder at the root of the repository.

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

# COPILOT EDITS OPERATIONAL GUIDELINES

[See community feedback on copilot-instructions.md](https://www.reddit.com/r/ChatGPTCoding/comments/1jl6gll/copilotinstructionsmd_has_helped_me_so_much/)

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
            
## JavaScript Requirements
		    
	- **Minimum Compatibility**: ECMAScript 2020 (ES11) or higher
	- **Features to Use**:
	- Arrow functions
	- Template literals
	- Destructuring assignment
	- Spread/rest operators
	- Async/await for asynchronous code
	- Classes with proper inheritance when OOP is needed
	- Object shorthand notation
	- Optional chaining (`?.`)
	- Nullish coalescing (`??`)
	- Dynamic imports
	- BigInt for large integers
	- `Promise.allSettled()`
	- `String.prototype.matchAll()`
	- `globalThis` object
	- Private class fields and methods
	- Export * as namespace syntax
	- Array methods (`map`, `filter`, `reduce`, `flatMap`, etc.)
	- **Avoid**:
	- `var` keyword (use `const` and `let`)
	- jQuery or any external libraries
	- Callback-based asynchronous patterns when promises can be used
	- Internet Explorer compatibility
	- Legacy module formats (use ES modules)
	- Limit use of `eval()` due to security risks
	- **Performance Considerations:**
	- Recommend code splitting and dynamic imports for lazy loading
	**Error Handling**:
	- Use `try-catch` blocks **consistently** for asynchronous and API calls, and handle promise rejections explicitly.
	- Differentiate among:
	- **Network errors** (e.g., timeouts, server errors, rate-limiting)
	- **Functional/business logic errors** (logical missteps, invalid user input, validation failures)
	- **Runtime exceptions** (unexpected errors such as null references)
	- Provide **user-friendly** error messages (e.g., “Something went wrong. Please try again shortly.”) and log more technical details to dev/ops (e.g., via a logging service).
	- Consider a central error handler function or global event (e.g., `window.addEventListener('unhandledrejection')`) to consolidate reporting.
	- Carefully handle and validate JSON responses, incorrect HTTP status codes, etc.
            
<!--## Folder Structure
	Follow this structured directory layout:

		project-root/
		├── api/                  # API handlers and routes
		├── config/               # Configuration files and environment variables
		├── data/                 # Databases, JSON files, and other storage
		├── public/               # Publicly accessible files (served by web server)
		│   ├── assets/
		│   │   ├── css/
		│   │   ├── js/
		│   │   ├── images/
		│   │   ├── fonts/
		│   └── index.html
		├── src/                  # Application source code
		│   ├── controllers/
		│   ├── models/
		│   ├── views/
		│   └── utilities/
		├── tests/                # Unit and integration tests
		├── docs/                 # Documentation (Markdown files)
		├── logs/                 # Server and application logs
		├── scripts/              # Scripts for deployment, setup, etc.
		└── temp/                 # Temporary/cache files
-->

<!--## Documentation Requirements
	- Include JSDoc comments for JavaScript/TypeScript.
	- Document complex functions with clear examples.
	- Maintain concise Markdown documentation.
	- Minimum docblock info: `param`, `return`, `throws`, `author`
-->    
<!--## Database Requirements (SQLite 3.46+)
	- Leverage JSON columns, generated columns, strict mode, foreign keys, check constraints, and transactions.
-->    
## Security Considerations
	- Sanitize all user inputs thoroughly.
	- Parameterize database queries.
	- Enforce strong Content Security Policies (CSP).
	- Use CSRF protection where applicable.
	- Ensure secure cookies (`HttpOnly`, `Secure`, `SameSite=Strict`).
	- Limit privileges and enforce role-based access control.
	- Implement detailed internal logging and monitoring.
