Create a Blazor Server App in .NET 8.0 for training developers to use GitHub Copilot. The application should include:

1. A home page introducing the training app.
2. Four Razor pages as separate labs:
   - Lab 1: A calculator with intentional logic errors for Copilot-assisted debugging.
   - Lab 2: A unit test scaffold using NUnit for the calculator service.
   - Lab 3: Instructions to use Copilot to generate a README.md file.
   - Lab 4: A button that loads static data using a service — prompt Copilot to scaffold a Web API to support this.

Add a `CalculatorService` class in `Services/` with intentional bugs in the methods Add, Subtract, and Divide.

Add a `CalculatorServiceTests.cs` file in `Tests/` with a `[Test]` method where Copilot can be prompted to write unit tests.

Add an `ApiDataService` class that returns hardcoded data. Include instructions to replace it with a real API using Copilot.

Include:
- A `MainLayout.razor` and `NavMenu.razor` to navigate between labs.
- A `README.md` scaffold explaining the purpose of the app and how to use Copilot with it.
- Markdown instructions for each lab in a `LabInstructions/` folder.
- A `.github/copilot-instructions.md` file with style and structure guidelines for Copilot.
- A `.github/copilot-custom-prompts.md` file with useful chat prompts for developers.

Use C# 12 and follow standard .NET conventions.
