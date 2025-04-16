# GitHub Copilot Instructions for Copilot Training App

This project is a .NET 8.0 Blazor Server app designed to train developers on GitHub Copilot through structured labs. The project intentionally contains errors and patterns for learning purposes. Use the following instructions to help Copilot align with our coding conventions and architecture.

---

## 🔧 General Coding Standards

- Use **C# 12** features where appropriate.
- Follow standard **.NET naming conventions**: 
  - Classes and Methods: `PascalCase`
  - Variables and Parameters: `camelCase`
- Avoid abbreviations in method names.
- Prefer `async/await` for asynchronous operations.
- Write XML documentation comments for public members when not in training labs.

---

## 🧱 Project Structure Guidelines

- **Services** go in `/Services/`, and contain application logic (e.g. `CalculatorService.cs`).
- **Pages** go in `/Pages/`, and should use `.razor` files with minimal logic in code-behind.
- **Models** go in `/Models/`, and should be simple POCO classes.
- **Unit tests** are located in `/Tests/`, and use **NUnit** as the test framework.
- The app uses **dependency injection** for services in `Program.cs`.

---

## 🧪 Unit Testing

- Use `NUnit.Framework` for all tests.
- Each test class should correspond to a service (e.g. `CalculatorServiceTests.cs`).
- Use `[SetUp]` to initialize test fixtures.
- Method names should describe intent clearly, e.g. `Add_ShouldReturnCorrectResult`.

---

## 🧠 Blazor-Specific Guidelines

- Use `@inject` to bring services into Razor components.
- Use `@code` blocks for local component logic.
- Use `MainLayout.razor` as the default layout for all pages.
- Prefer component reuse over copy-pasting code.

---

## 🧠 Copilot Usage Tips (Meta)

- Encourage prompts like:
  - “Fix the bug in this method”
  - “Write an NUnit test for this
