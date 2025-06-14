---
applyTo: "**/*.cs"
---

# Project coding standards

## General C# Coding Standards
- Use `var` only when the type is obvious from the right-hand side; otherwise, use explicit types.
- Use consistent indentation and always use braces, even for single-line blocks.
- Keep line length under 120 characters.
- Organize `using` directives alphabetically and group system namespaces first.

## Naming Conventions
- Use `PascalCase` for class names, methods, properties, and namespaces.
- Use `camelCase` for variables and method parameters.
- Prefix private fields with `_` and use `camelCase` (e.g., `_service`).
- Avoid abbreviations; prefer descriptive and meaningful names.

## Design Patterns & Architecture
- Follow the SOLID principles.
- Prefer composition over inheritance.
- Use Dependency Injection for decoupling and testability.
- Apply appropriate design patterns such as Repository, Strategy, Factory, and Adapter where applicable.
- Follow Clean Architecture when structuring large applications.

## Code Quality and Maintainability
- Keep methods small and focused; one method should do one thing only.
- Avoid magic numbers and strings�use constants or enums.
- Prefer modern C# features such as:
  - Pattern matching
  - Null-coalescing operators (`??`, `??=`)
  - `switch` expressions
  - Records and value types
  - Expression-bodied members

## Performance and Memory Efficiency
- Avoid unnecessary allocations (e.g., avoid `ToList()` unless required).
- Use `Span<T>` and `Memory<T>` when working with slices of data.
- Prefer `ValueTask` over `Task` in performance-critical async methods.
- Avoid boxing/unboxing and excessive object creation in loops or hot paths.

## Error Handling and Logging
- Do not silently catch or suppress exceptions.
- Catch only specific exception types when possible.
- Use exception filters and `when` clauses to improve readability.
- Use logging frameworks (e.g., Serilog, Microsoft.Extensions.Logging) for structured logging.

## Security Best Practices
- Validate all input, especially data coming from clients or external sources.
- Avoid hardcoded credentials or API keys. Use secrets management or configuration files.
- Sanitize and encode output to prevent XSS or injection attacks.
- Use secure algorithms for hashing and encryption (e.g., SHA-256, AES-GCM).

## Testability
- Favor interfaces and abstractions over concrete types.
- Use dependency injection and mocking libraries for unit tests.
- Avoid static classes when testability is important.
- Write unit tests using xUnit, NUnit, or MSTest with clear Arrange/Act/Assert structure.

Coding standards, domain knowledge, and preferences that AI should follow.

## Namespaces
- Use file-scoped namespaces that match the folder structure.

## Immutability
- Prefer immutable types unless mutability is requested.
- Prefer records over classes for immutable types.

## Files Organization
- Define one type per file.

## Record Design
- Define record's properties on the same line with the record declaration.
- Accompany each record `<name>` with `<name>Factory` static factory class.
- Place the factory class in the same file as the record.
- Expose static `Create` method in the factory class for instantiation.
- Place argument validation in the `Create` method.
- Never use record's constructor when there is a factory method.
- Use immutable collections in records unless requested otherwise.
- Use `ImmutableList<T>` in records whenever possible.
- Define record behavior in extension methods in other static classes.

## Discriminated Unions Design
- Prefer using records for discriminated unions.
- Derive specific types from a base abstract record.
- Define the entire discriminated union in one file.
- Define one static factories class per discriminated union.
- Expose one static factory method per variant.
- Follow all rules for record design when designing a discriminated union.
