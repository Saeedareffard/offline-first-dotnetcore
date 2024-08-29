# Retail Inventory Management System

## Overview

The **Retail Inventory Management System** is a robust and scalable solution designed for managing inventory across multiple store locations within a retail chain. Built with ASP.NET Core, this system features an offline-first architecture, allowing stores to continue operating independently even during network outages. Once connectivity is restored, the system automatically synchronizes local inventory data with a central server.

This project follows the SOLID principles to ensure a maintainable and extensible codebase. The architecture is designed to handle various inventory-related operations, including product management, inventory tracking, and transfer requests between locations.

## Features

- **Offline-First Design:** Ensures operations continue seamlessly even when connectivity is lost. Local data is automatically synced with the central server when the network is available.
- **Multi-Location Support:** Manage inventory across multiple store locations with real-time synchronization.
- **Product Management:** CRUD operations for managing product details, including SKU, price, and stock levels.
- **Inventory Tracking:** Track and update stock levels at each store location.
- **Transfer Requests:** Facilitate inventory transfers between store locations to balance stock levels.
- **Extensible Architecture:** Easily extendable to accommodate additional features and business requirements.

## Technologies Used

- **ASP.NET Core:** Backend framework for building the web API and business logic.
- **Entity Framework Core:** ORM for managing database interactions.
- **SQLite:** Used for local storage in offline-first scenarios.
- **SQL Server:** Central database for storing synchronized inventory data.
- **HttpClient:** For handling communication between local stores and the central server.
- **SOLID Principles:** Ensuring maintainable and scalable code.


markdown


## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [SQLite](https://www.sqlite.org/download.html)
- [Postman](https://www.postman.com/downloads/) (for testing and mock server setup)

### Setup Instructions

1. **Clone the Repository:**

   ```bash
   git clone https://github.com/yourusername/RetailInventoryManagement.git
   cd RetailInventoryManagement
Configure the Database:

Update the connection strings in appsettings.json to point to your local SQL Server and SQLite instances.
Run Migrations:

bash
Copy code
dotnet ef migrations add InitialCreate
dotnet ef database update
Build and Run the Application:

bash
Copy code
dotnet build
dotnet run
Set Up the Postman Mock Server:

Import the provided Postman_Mock_Server.json into Postman.
Create a mock server and replace the base URL in the application with the mock server URL.
Test the API Endpoints:

Use Postman to test the different endpoints provided by the application.
Ensure the synchronization logic works correctly by sending requests to the mock server.
API Endpoints
Products
GET /api/products - Retrieve a list of all products.
POST /api/products - Add a new product.
PUT /api/products/{id} - Update an existing product.
DELETE /api/products/{id} - Delete a product.
Inventory
GET /api/inventory - Retrieve inventory levels for all locations.
POST /api/inventory - Update inventory for a specific location.
POST /api/inventory/sync - Sync local inventory with the central server.
Transfer Requests
GET /api/transferrequests - Retrieve a list of all transfer requests.
POST /api/transferrequests - Create a new transfer request.
PUT /api/transferrequests/{id} - Update the status of a transfer request.



---

