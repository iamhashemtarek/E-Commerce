# ECommerce.ITI

ECommerce.ITI is an e-commerce application built using ASP.NET Core and Entity Framework Core. The project demonstrates a clean architecture with a repository pattern, unit of work, and specification pattern for querying data.

## Table of Contents

- [Features](#features)
- [Technologies](#technologies)
- [Getting Started](#getting-started)
- [Project Structure](#project-structure)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)

## Features

- User authentication and authorization using ASP.NET Identity
- Product management with categories and brands
- Order processing with delivery methods
- Secure payment processing using Stripe
- Specification pattern for flexible querying
- Unit of work pattern for managing transactions
- AutoMapper for object-object mapping

## Technologies

- ASP.NET Core 9.0
- Entity Framework Core 9.0
- SQL Server
- AutoMapper
- ASP.NET Identity
- FluentValidation

## Getting Started

### Prerequisites

- .NET 9.0 SDK
- SQL Server

### Installation

1. Clone the repository:
   
```
   git clone https://github.com/yourusername/ECommerce.ITI.git
   cd ECommerce.ITI
   
```

2. Set up the database:
   - Update the connection string in `appsettings.json`:
     
```json
     {
       "ConnectionStrings": {
         "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=ECommerceDb;Trusted_Connection=True;MultipleActiveResultSets=true",
         "IdentityConnection": "Server=(localdb)\\mssqllocaldb;Database=IdentityDb;Trusted_Connection=True;MultipleActiveResultSets=true"
       }
     }
     
```

   - Apply migrations:
     
```
     dotnet ef database update --project ECommerce.Repository --context StoreContext
     dotnet ef database update --project ECommerce.Repository --context AppIdentityDbContext
     
```

3. Run the application:
   
```
   dotnet run --project ECommerce.APIs
   
```

## Project Structure

- **ECommerce.Core**: Contains the core entities, interfaces, and specifications.
- **ECommerce.Repository**: Implements the repository pattern, unit of work, and database context.
- **ECommerce.APIs**: Contains the API controllers and configuration.

## Usage

### API Endpoints

- **Products**
  - `GET /api/products`: Get all products
  - `GET /api/products/{id}`: Get a product by ID
  - `POST /api/products`: Create a new product
  - `PUT /api/products/{id}`: Update a product
  - `DELETE /api/products/{id}`: Delete a product

- **Orders**
  - `GET /api/orders`: Get all orders
  - `GET /api/orders/{id}`: Get an order by ID
  - `POST /api/orders`: Create a new order

- **Authentication**
  - `POST /api/account/register`: Register a new user
  - `POST /api/account/login`: Login a user

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any improvements or bug fixes.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

