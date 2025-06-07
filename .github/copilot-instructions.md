# Blazor WebAssembly .NET 9 – Copilot & Contributor Guidelines

This repository is a C# Blazor WebAssembly project targeting .NET 9, built with Visual Studio 2022.

---

## 1. Commit Message Standards

- **Conventional Commits:**  
  Format: `<type>(<scope>): <short description>`
  - **Types:** `feat`, `fix`, `docs`, `style`, `refactor`, `test`, `chore`
  - **Scopes:** `blazor`, `api`, `ui`, `db`, `auth`
  - **First line:** <72 characters
- **Body:** 2–3 sentences explaining *what* changed and *why*
- **Example:**  
  `feat(blazor): add login component`  
  Created `Login.razor` with form validation. Integrated EF Core for user auth. Follows .NET 9 Blazor standards.

---

## 2. Coding Standards

- **Target:** .NET 9 (Blazor WebAssembly)
- **Language:** C# (use C# 12/13 features)
- **Component Structure:**  
  - UI: Razor components (`.razor`)
  - Logic: Partial classes for code-behind
- **Naming:**  
  - PascalCase for types/members
  - camelCase for variables/parameters
- **Async:** Use `async`/`await` for all async operations
- **Dependency Injection:** Use Blazor DI for services
- **State Management:**  
  - Use cascading parameters, DI services, or built-in patterns
- **Blazor Best Practices:**  
  - Use `@inject` for services
  - Prefer strongly-typed parameters
  - Use `OnInitialized[Async]`, `OnParametersSet[Async]` for lifecycle
  - Use `EventCallback<T>` for event binding

---

## 3. UI & Styling

- **Framework:** [Zurb Foundation](https://get.foundation/) for all UI/layouts
- **Custom Styles:**  
  - Place in `wwwroot/css` or `wwwroot/scss`
- **Responsive Design:**  
  - Use Foundation grid/utilities or custom CSS
- **Accessibility:**  
  - Semantic HTML, ARIA roles, keyboard navigation, color contrast
  - Labels for all form fields
  - Alt/aria-label for media
  - Ensure all UI changes comply with WCAG 2.1 AA (AAA where feasible)
  - Use semantic HTML5 and ARIA roles throughout
  - Audit accessibility with Lighthouse or similar tools as needed
- **Performance:**  
  - Optimize static assets
  - Use lazy loading for components/assets
- **HTML/CSS/Assets:**  
  - Use modern CSS (Grid, Flexbox, variables, nesting, dark mode)
  - Optimize images (WebP, AVIF), use `loading="lazy"`, `srcset`, and SEO tags
- **Minimal JavaScript:**  
  - Use C#/Blazor for client logic
  - JS interop only if necessary, with clear separation
- **Security & Quality:**  
  - Sanitize all user inputs and parameterize queries.
  - Enforce strong Content Security Policy (CSP).
  - Use secure cookies, RBAC, and internal logging/monitoring.
  - Ensure all code builds and passes tests before submitting a pull request.

---

## 4. Security & API

- **Input Validation:** Always validate/sanitize user input
- **XSS/CSRF:** Prevent via Blazor built-ins and best practices
- **Secrets:** Never expose secrets in client code
- **API:**  
  - Use strongly-typed `HttpClient` via DI
  - Prefer minimal APIs for backend
- **CSP:** Enforce strong Content Security Policy
- **Authentication:**  
  - Use ASP.NET Core Identity or similar
  - Enforce role-based access control

---

## 5. Testing & Documentation

- **Unit Tests:**  
  - Use xUnit for logic/services
  - Use bUnit for components
- **Integration/E2E:**  
  - Use Playwright for UI/flows
- **Accessibility Tests:**  
  - Use bUnit/axe or Playwright accessibility checks
- **Documentation:**  
  - XML docs for public APIs
  - Keep README and API docs (Swagger/OpenAPI) up to date

---

## 6. Modern C# Features (12/13 Quick Reference)

| Feature                  | Example Snippet |
|--------------------------|----------------|
| Primary Constructors     | `public class Person(string name, int age) { ... }` |
| Collection Expressions   | `int[] nums = [1,2,3];` |
| Default Lambda Params    | `Func<int,int,int> add = (x, y=5) => x+y;` |
| ref readonly Parameters  | `void M(ref readonly int x) { ... }` |
| Alias Any Type           | `using IntPair = (int, int);` |
| Inline Arrays            | `[InlineArray(10)] struct Buffer { ... }` |
| params Collections       | `void M(params ReadOnlySpan<T> items) { ... }` |
| New Lock Object          | `var l = new Lock(); using(l.EnterScope()) { ... }` |
| New Escape Sequence      | `char esc = '\e';` |
| Method Group Natural Type| `var act = (string s) => ...;` |
| Implicit Index Access    | `buffer = { [^1]=0 }` |
| ref/unsafe in Iterators  | `async Task M() { ref int x = ...; }` |
| Partial Properties       | `public partial string Name { get; set; }` |
| Overload Priority        | `[OverloadResolutionPriority(1)] void M(int a) {}` |

---

## 7. File & Directory Organization

- **Features:**  
  - Place each feature in its own subfolder: `src/MainProject/Features/FeatureName/`
    - Include Razor components, code-behind, and feature-specific CSS here.
- **Feature Subcomponents:**  
  - Place reusable or nested components in: `src/MainProject/Features/FeatureName/Components/`
- **Static Assets:**  
  - Place all static assets in: `src/MainProject/wwwroot/`
    - Use subfolders: `css/`, `scss/`, `lib/`, `sample-data/`
- **Tests:**  
  - Place all unit, integration, and component tests in: `tests/`
    - Mirror the main project structure for clarity.
- **Scripts:**  
  - Place deployment, setup, and utility scripts in: `scripts/`
- **Subprojects/Component Projects:**  
  - Place additional projects in: `src/SubProjectName/`

**Directory Layout:**
<pre>
project-root/
├── src/
│   ├── MainProject/
│   │   ├── Features/
│   │   │   ├── Feature-1/
│   │   │   │   ├── Components/
│   │   │   ├── Feature-2/
│   │   │   ├── Feature-N/
│   │   ├── wwwroot/
│   │   │   ├── css/
│   │   │   ├── scss/
│   │   │   ├── lib/
│   │   │   ├── sample-data/
│   ├── SubProject-1/
│   ├── SubProject-2/
│   ├── SubProject-N/
├── tests/
│   ├── MainProject.Tests/
│   ├── SubProject-1.Tests/
├── scripts/
</pre>

---

## 8. Best Practices

- Write modular, reusable, and testable components
- Use strongly-typed parameters and validate input
- Handle exceptions gracefully
- Reference code with filename and line number in discussions
- Prefer C# and Blazor features over JS/CSS/HTML unless requested
- Ensure all code builds and passes tests before PRs

---

## 9. Copilot Edits Operational Guidelines

- **General Principles:**
  - Edit only one file at a time to prevent merge conflicts and file corruption.
  - For large or complex changes, always start with a clear, step-by-step plan before making any edits.
  - Communicate your plan and await explicit approval before proceeding with each step.

- **Edit Workflow:**
  1. **Planning:**  
     - Outline all functions/sections to modify, the order of changes, dependencies, and estimated number of edits.
     - Present the plan for review and approval.
  2. **Execution:**  
     - Make one conceptual change per edit.
     - After each edit, show before/after snippets and a concise explanation.
     - Confirm completion and request approval before the next step.
     - If new changes are discovered, pause and update the plan for approval.
  3. **Refactoring:**  
     - Break work into logical, independently functional chunks.
     - Ensure each intermediate state is functional and builds successfully.
     - Temporary duplication is acceptable for large refactors if it maintains stability.

- **Error Handling & Communication:**
  - Clearly indicate progress after each edit (e.g., "✅ Completed edit [#] of [total]. Ready for next edit?").
  - If you encounter blockers or ambiguities, pause and request clarification.
  - Reference code by filename and line number when discussing changes.

- **Adherence to Project Standards:**
  - Follow all repository coding, testing, and documentation standards.
  - Prefer C# and Blazor features over JavaScript or custom HTML/CSS unless explicitly required.

---

*For further details, see README and project-specific documentation.*