# Copilot Training App

## About
This is a training application built with Blazor and .NET 8.0. It includes labs for using GitHub Copilot to:
- Debug errors
- Write unit tests with NUnit
- Generate project documentation
- Create and consume simple Web APIs

## Labs
1. **Lab 1:** Fix bugs in CalculatorService.cs using GitHub Copilot
2. **Lab 2:** Use Copilot to generate NUnit tests in `CalculatorServiceTests.cs`
3. **Lab 3:** Prompt Copilot to document this project in this README.md file
4. **Lab 4:** Use Copilot to scaffold and consume a simple Web API in `ApiLab.razor`

## Architecture

The following diagram shows the data flow and component architecture of the Copilot Training App:

```mermaid
graph TD
    A[User] --> B[Blazor Server App]
    
    subgraph "Blazor Pages"
        B --> C[Index.razor - Home]
        B --> D[ErrorsLab.razor - Lab 1]
        B --> E[UnitTestLab.razor - Lab 2] 
        B --> F[ReadmeLab.razor - Lab 3]
        B --> G[ApiLab.razor - Lab 4]
        B --> H[RefactorLab.razor - Lab 5]
    end
    
    subgraph "Services Layer"
        I[CalculatorService]
        J[ApiDataService]
        K[StringFormatter]
    end
    
    subgraph "Dependency Injection"
        L[Program.cs]
        L --> M[DI Container]
        M --> I
        M --> J
        M --> K
    end
    
    subgraph "Data Flow"
        D -->|@inject| I
        D --> N["User Input: value1 and value2"]
        N --> O[Add/Subtract/Divide Operations]
        O --> P[Result Display]
        
        G -->|@inject| J
        G --> Q[Load Data Button]
        Q --> R[GetDataAsync Method]
        R --> S[Static Data List]
        
        H --> T[StringFormatter Logic]
        T --> U[Refactoring Exercise]
    end
    
    subgraph "Learning Objectives"
        V[Lab 1: Debug with Copilot]
        W[Lab 2: Generate Tests]
        X[Lab 3: Create Documentation]
        Y[Lab 4: Build APIs]
        Z[Lab 5: Refactor Code]
    end
    
    D -.-> V
    E -.-> W
    F -.-> X
    G -.-> Y
    H -.-> Z
    
    style A fill:#e1f5fe
    style B fill:#f3e5f5
    style I fill:#fff3e0
    style J fill:#fff3e0
    style K fill:#fff3e0
    style L fill:#e8f5e8
```

## Getting Started
Run the app with:
```
dotnet run
```
Open in Visual Studio 2019 or 2022 and explore each lab via the UI.

## Suggested Prompts
- "Fix the bug in this Add method"
- "Generate NUnit tests for this class"
- "Write a README for this project"
- "Create a Web API controller to serve sample data"

---

Let Copilot guide you and observe the code it generates!