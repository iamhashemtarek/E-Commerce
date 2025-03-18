# ECommerce Solution

This solution is an e-commerce application built using .NET 9.0. It consists of multiple projects, each serving a specific purpose within the application. The main projects included in this solution are:

- `ECommerce.APIs`: The API layer of the application.
- `ECommerce.Repository`: The data access layer.
- `ECommerce.Service`: The business logic layer.
- `ECommerce.Core`: The core entities and contracts.

## Table of Contents

- [Projects](#projects)
  - [ECommerce.APIs](#ecommerceapis)
  - [ECommerce.Repository](#ecommercerepository)
  - [ECommerce.Service](#ecommerceservice)
  - [ECommerce.Core](#ecommercecore)
- [Features](#features)
- [Getting Started](#getting-started)
  - [Prerequisites](#prerequisites)
  - [Installation](#installation)
  - [Setting Up the Database](#setting-up-the-database)
  - [Building the Solution](#building-the-solution)
  - [Running the Application](#running-the-application)
- [API Endpoints](#api-endpoints)
- [Contributing](#contributing)
- [License](#license)

## Projects

### ECommerce.APIs

This project is the API layer of the application. It is built using ASP.NET Core and targets .NET 9.0. The project includes the following packages:

- `AutoMapper`: For object-object mapping.
- `Microsoft.AspNetCore.OpenApi`: For OpenAPI/Swagger support.
- `Microsoft.EntityFrameworkCore.Tools`: For Entity Framework Core tools.
- `Swashbuckle.AspNetCore`: For Swagger generation.

#### Project References

- `ECommerce.Repository`: References the data access layer.
- `ECommerce.Service`: References the business logic layer.

### ECommerce.Repository

This project is the data access layer of the application. It is responsible for interacting with the database using Entity Framework Core.

### ECommerce.Service

This project is the business logic layer of the application. It contains the core business logic and interacts with the repository layer to perform data operations.

### ECommerce.Core

This project contains the core entities and contracts used across the application.

## Features

- RESTful API built with ASP.NET Core
- Entity Framework Core for data access
- AutoMapper for object-object mapping
- Swagger for API documentation
- Modular architecture with separate projects for API, service, repository, and core layers
- JWT Authentication
- Redis for caching
- Stripe integration for payments

## Getting Started

### Prerequisites

- .NET 9.0 SDK
- Visual Studio 2022
- SQL Server or any other supported database

### Installation

1. Clone the repository.
   
   
```
   git clone https://github.com/your-repo/ecommerce-solution.git
   
```
2. Open the solution in Visual Studio 2022.

### Setting Up the Database

1. Update the connection strings in `appsettings.json` in the `ECommerce.APIs` project.
   
   
```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;",
     "IdentityConnection": "Server=your_server;Database=your_identity_database;User Id=your_user;Password=your_password;",
     "Redis": "localhost"
   }
   
```
2. Apply migrations to set up the database schema.
   
   
```
   dotnet ef database update --project ECommerce.Repository
   
```

### Building the Solution

1. Restore the NuGet packages.
2. Build the solution.

### Running the Application

1. Set `ECommerce.APIs` as the startup project.
2. Run the application using Visual Studio or the .NET CLI.
   
   
```
   dotnet run --project ECommerce.APIs
   
```

## API Endpoints

The API documentation is generated using Swagger. Once the application is running, you can access the Swagger UI at `http://localhost:<port>/swagger`.

### Example Endpoints

- `GET /api/products`: Retrieve a list of products.
- `GET /api/products/{id}`: Retrieve a specific product by ID.
- `POST /api/products`: Create a new product.
- `PUT /api/products/{id}`: Update an existing product.
- `DELETE /api/products/{id}`: Delete a product.

## Contributing

Contributions are welcome! Please fork the repository and submit pull requests.

## License

This project is licensed under the MIT License.
