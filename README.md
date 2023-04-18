## Electronic Store System 

### Technologies Used
-   C#
-   .NET 6
-   ASP.NET Core Web API
-   Entity Framework Core
-   SQL Server
-   AutoMapper

### Architecture Overview

The project follows a clean architecture pattern with separation of concerns between different layers. The architecture consists of four layers:
>  Domain layer: contains the domain entities, Enums, Repositories.
>  Application layer: contains the use cases and application services that implement the business logic.
>  Infrastructure layer: contains the implementation details, such as repositories and database access code.
>  Web API layer: contains the API controllers.
 

### Design Patterns

 - Repository pattern
 - Builder pattern
 - Adapter pattern
 - Proxy pattern
 - Decorator pattern
 - Command pattern
 - Observer pattern
 - State pattern


### Project Structure

The project structure follows a modular approach with separate projects for each layer:

-   ApplicationDemo.Domain
-   ApplicationDemo.Application
-   ApplicationDemo.Infrastructure
-   ApplicationDemo

Each project contains the necessary folders and files for the layer's implementation.
