# redmuffin.Blazor.Static (preview - alpha)

[![Build Status](https://github.com/michaelvolz/redmuffin.Blazor.Static/actions/workflows/azure-static-web-apps-lively-cliff-0945be603.yml/badge.svg)](https://github.com/michaelvolz/redmuffin.Blazor.Static/actions/workflows/azure-static-web-apps-lively-cliff-0945be603.yml)
[![CodeQL](https://github.com/michaelvolz/redmuffin.Blazor.Static/actions/workflows/codeql.yml/badge.svg)](https://github.com/michaelvolz/redmuffin.Blazor.Static/actions/workflows/codeql.yml)
[![Last Commit (master)](https://img.shields.io/github/last-commit/michaelvolz/redmuffin.Blazor.Static/master.svg)](https://github.com/michaelvolz/redmuffin.Blazor.Static/commits/master)

[![License: Unlicense](https://img.shields.io/badge/license-Unlicense-blue.svg)](https://en.wikipedia.org/wiki/Unlicense)
[![Dependabot enabled](https://img.shields.io/badge/Dependabot-enabled-blue.svg)](https://docs.github.com/en/code-security/dependabot/working-with-dependabot)
![GitHub language count](https://img.shields.io/github/languages/count/michaelvolz/OpenGraphTilemakerReborn)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/michaelvolz/OpenGraphTilemakerReborn)

---

## Overview

**redmuffin.Blazor.Static** is a Blazor WebAssembly project targeting .NET 9, designed for building modern, performant, and maintainable static web applications. The solution leverages [Markdig](https://github.com/xoofx/markdig) for Markdown integration and follows best practices for accessibility, security, and maintainability.

---

## Table of Contents

- [Features](#features)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Usage](#usage)
- [Project Structure](#project-structure)
- [Technology Stack](#technology-stack)
- [Contributing](#contributing)
- [License](#license)

---

## Features

- Blazor WebAssembly (.NET 9)
- Modern C# (C# 12/13) features
- Markdown rendering via Markdig
- SCSS/CSS asset pipeline
- Automated builds and code analysis
- Dependabot integration

---

## Prerequisites

- **Visual Studio 2022** (17.8 or later) with the following workloads:
  - ASP.NET and web development
- **.NET 9 SDK**
- **WebCompiler 2022+** Visual Studio 2022 extension  
  [Download from Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.WebCompiler)
  - Required for compiling SCSS/LESS files to CSS via `compilerconfig.json`

---

## Getting Started

1. **Clone the repository:**
2. **Install prerequisites:**
- Ensure Visual Studio 2022 and .NET 9 SDK are installed.
- Install the [WebCompiler 2022+ extension](https://marketplace.visualstudio.com/items?itemName=MadsKristensen.WebCompiler) in Visual Studio.

3. **Open the solution:**
- Open `redmuffin.Blazor.Static.sln` in Visual Studio 2022.

4. **Restore and build:**
- Restore NuGet packages and build the solution.

---

## Usage

- Run the project using Visual Studio or the .NET CLI:
- The application will be available at `https://localhost:5001` (or the configured port).

---

## Project Structure

The project follows a [feature folder structure](https://blog.ndepend.com/feature-folders-are-superior-to-layered-architecture/) to organize code by feature rather than by technical layer. This approach improves maintainability and scalability by grouping related components, services, and assets together.

---

## Technology Stack

- **[C#](https://learn.microsoft.com/en-us/dotnet/csharp/)**  
  A modern, object-oriented programming language developed by Microsoft. The project utilizes the latest C# 12/13 features for concise, robust, and maintainable code.

- **[Blazor](https://dotnet.microsoft.com/apps/aspnet/web-apps/blazor)**  
  A framework for building interactive web UIs using C# instead of JavaScript. This project uses Blazor WebAssembly, enabling client-side execution of .NET code in the browser.

- **[.NET Core / .NET 9](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)**  
  A cross-platform, high-performance framework for building modern cloud, web, and desktop applications. The project targets .NET 9 for the latest features and performance improvements.

- **[SCSS (Sass)](https://sass-lang.com/documentation/syntax#scss)**  
  A powerful CSS preprocessor that adds variables, nesting, and modularization to CSS. SCSS is compiled to standard CSS using WebCompiler for maintainable and scalable stylesheets.

- **[Zurb Foundation](https://get.foundation/)**  
  A responsive front-end framework providing a robust grid system, UI components, and accessibility features. Used as the primary CSS framework for consistent and accessible design.

- **[Markdig Renderer](https://github.com/xoofx/markdig)**  
  A fast, extensible Markdown processor for .NET. Markdig is used to render Markdown content within the application.

- **[LibMan (Library Manager)](https://learn.microsoft.com/en-us/aspnet/core/client-side/libman/)**  
  A lightweight, client-side library acquisition tool for web projects. LibMan is used to manage third-party client-side libraries such as Foundation.

- **[Code Analyzer](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/overview)**  
  Static code analysis tools integrated into the build process to enforce code quality, security, and maintainability standards.

- **[WebCompiler](https://github.com/madskristensen/WebCompiler)**  
  A Visual Studio extension for compiling SCSS, LESS, and other preprocessor files into CSS. Ensures that styles are always up to date and optimized.

- **[GitHub Copilot](https://github.com/features/copilot)**  
  An AI-powered code completion tool that assists with writing code, documentation, and tests, improving productivity and code quality.

---

## Contributing

Contributions are welcome! Please see [CONTRIBUTING.md](CONTRIBUTING.md) for guidelines.

---

## License

This project is licensed under the [Unlicense](https://unlicense.org/).

---

## Acknowledgements

- [Markdig](https://github.com/xoofx/markdig) for Markdown processing
- [WebCompiler](https://github.com/madskristensen/WebCompiler) for SCSS/LESS compilation
- [Zurb Foundation](https://get.foundation/) for the CSS framework
- [GitHub Copilot](https://github.com/features/copilot) for AI code assistance
- [Visual Studio](https://visualstudio.microsoft.com/) for development environment

--- 