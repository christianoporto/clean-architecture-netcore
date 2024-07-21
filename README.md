# CleanArchitectureApp
## Overview
CleanArchitectureApp is a .NET Core 8 solution template implementing the Clean Architecture principles. This template provides a solid starting point for building scalable, maintainable, and testable applications. It separates the concerns into different layers, promoting a clean and organized project structure.

# Project Structure
The solution is structured as follows:

```
CleanArchitectureApp
├── src
│   ├── CleanArchitectureApp.Domain
│   │   ├── CleanArchitectureApp.Domain.csproj
│   ├── CleanArchitectureApp.Application
│   │   ├── CleanArchitectureApp.Application.csproj
│   ├── CleanArchitectureApp.Infrastructure
│   │   ├── CleanArchitectureApp.Infrastructure.csproj
│   └── CleanArchitectureApp.Api
│       ├── CleanArchitectureApp.Api.csproj
├── tests
│   ├── CleanArchitectureApp.Domain.Tests
│   │   ├── CleanArchitectureApp.Domain.Tests.csproj
│   ├── CleanArchitectureApp.Application.Tests
│   │   ├── CleanArchitectureApp.Application.Tests.csproj
│   ├── CleanArchitectureApp.Infrastructure.Tests
│   │   ├── CleanArchitectureApp.Infrastructure.Tests.csproj
│   └── CleanArchitectureApp.Api.Tests
│       ├── CleanArchitectureApp.Api.Tests.csproj
├── docs
├── scripts
└── CleanArchitectureApp.sln
```

# Layers

## Domain
The Domain layer contains the core business logic and domain entities. This layer is independent of any other layer, and changes here should not affect the other layers.

## Application
The Application layer contains the application logic. It defines the operations that can be performed within the system. This layer depends on the Domain layer but remains independent of the Infrastructure and API layers.

## Infrastructure
The Infrastructure layer contains the implementation details for accessing external resources such as databases, file systems, and other services. It depends on both the Domain and Application layers.

## API
The API layer exposes the application logic via a web API. This layer depends on the Application and Infrastructure layers.

## Testing
Each layer has its corresponding test project under the tests directory:

- CleanArchitectureApp.Domain.Tests
- CleanArchitectureApp.Application.Tests
- CleanArchitectureApp.Infrastructure.Tests
- CleanArchitectureApp.Api.Tests

# Getting Started
## Prerequisites
.NET Core 8 SDK
Visual Studio 2022 or Visual Studio Code

## Setup
1. Clone the repository:

```
git clone https://github.com/yourusername/CleanArchitectureApp.git
```

2. Navigate to the project directory:
```
cd CleanArchitectureApp
```

3. Open the solution in your preferred IDE:

```
code CleanArchitectureApp.sln
```

4. Restore the dependencies and build the solution:

```
dotnet restore
dotnet build
```

## Running the Application
To run the application, use the following command:

```
dotnet run --project src/CleanArchitectureApp.Api
```

## Running Tests
To run the tests, use the following command:

```
dotnet test
```

## Documentation
Documentation can be found in the docs directory. This includes detailed information on the architecture, design decisions, and how to extend the template for your needs.

## Scripts
The scripts directory contains various scripts for automating tasks like database migrations, code generation, etc. Refer to the documentation for more details.

## Contributing
Contributions are welcome! Please read the contributing guidelines for more information.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.

## Contact
For any questions or feedback, feel free to open an issue or contact the maintainers.

By using this template, you can ensure a clean separation of concerns and a maintainable codebase for your .NET Core applications. Happy coding!