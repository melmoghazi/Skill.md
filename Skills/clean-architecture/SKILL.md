---
name: csharp-clean-architecture
description: Instructions for adding new features, entities, or services using Clean Architecture in .NET. Use this when the user asks to "create a new feature," "add an endpoint," or "refactor logic."
---

# Clean Architecture C# Standards

## 1. Project Dependencies (The Golden Rule)
- **Domain**: Must have ZERO dependencies on other projects or external libraries (except basic tools like FluentValidation).
- **Application**: Depends only on **Domain**.
- **Infrastructure**: Depends on **Application** (to implement its interfaces).
- **WebAPI**: Depends on all layers for Dependency Injection.

## 2. Layer Responsibilities
### Domain
- Define **Entities** and **Value Objects** here.
- Place Repository **Interfaces** here (e.g., `IUserRepository`).
- No database logic or web logic allowed.

### Application
- Use the **Mediator pattern** (MediatR) for commands and queries.
- Each use case should have a Request, a Handler, and a Validator.
- Map Entities to DTOs here.

### Infrastructure
- Implement database contexts (EF Core) and Repositories here.
- Place external service implementations (Email, Cloud Storage) here.

### WebAPI
- Controllers should be thin; they only send commands/queries to the Application layer.
- Handle global exceptions via Middleware.

## 3. Coding Conventions
- Use **File-Scoped Namespaces** (C# 10+).
- Use **Primary Constructors** (C# 12+) for Dependency Injection.
- Naming: Interfaces must start with `I` (e.g., `ICurrentUserService`).
- Validation: Always use **FluentValidation** for incoming Application requests.

## 4. Common Commands
- Build: `dotnet build`
- Test: `dotnet test`
- Add Migration: `dotnet ef migrations add [Name] --project src/Infrastructure --startup-project src/WebAPI`
