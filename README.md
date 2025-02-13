# CRUD App

## Overview
This is a simple CRUD (Create, Read, Update, Delete) application built using **ASP.NET Core**. It provides RESTful APIs for managing products, utilizing **Entity Framework Core** for database interactions.

## Features
- Create, Read, Update, and Delete products
- RESTful API endpoints
- Entity Framework Core for database operations
- Configuration via `appsettings.json`

## Prerequisites
- .NET SDK (>=6.0)
- SQL Server
- Visual Studio or VS Code

## Installation
1. Clone the repository:
   ```sh
   git clone <repository_url>
   ```
2. Navigate to the project directory:
   ```sh
   cd CRUD-App-master/CRUD App
   ```
3. Restore dependencies:
   ```sh
   dotnet restore
   ```
4. Update the database connection string in `appsettings.json`:
   ```json
   "ConnectionStrings": {
       "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DB;User Id=YOUR_USER;Password=YOUR_PASSWORD;"
   }
   ```
5. Apply database migrations:
   ```sh
   dotnet ef database update
   ```

## Running the Application
To start the application, use:
```sh
dotnet run
```
The API will be accessible at `https://localhost:5001/` or `http://localhost:5000/`.

## API Endpoints
| Method | Endpoint | Description |
|--------|---------|-------------|
| GET | `/api/products` | Retrieve all products |
| GET | `/api/products/{id}` | Get a product by ID |
| POST | `/api/products` | Create a new product |
| PUT | `/api/products/{id}` | Update an existing product |
| DELETE | `/api/products/{id}` | Delete a product |

## Tools & Technologies Used
- **ASP.NET Core** - Web API framework
- **Entity Framework Core** - ORM for database operations
- **SQL Server** - Database
- **Swagger** - API documentation

## Contributing
Feel free to fork this repository and submit pull requests. Ensure your code follows best practices and includes necessary documentation.



