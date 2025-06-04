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