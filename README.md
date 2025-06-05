# redmuffin.Blazor.Static

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
