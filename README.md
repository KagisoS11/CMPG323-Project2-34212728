# CMPG323-Project2-34212728

# EcoPower Logistics API Project

The EcoPower Logistics API project repository. This project aims to create a set of RESTful APIs for managing solar energy products and logistics operations.

## Project Overview

EcoPower Logistics specializes in solar energy products and comprehensive logistics solutions. This project involves the creation of CRUD APIs to manage customers, orders, and products, and hosting these APIs on the Azure cloud platform.

## Features

- **Customer Management:** Create, Read, Update, and Delete customer records.
- **Order Management:** Manage orders, retrieve orders for specific customers.
- **Product Management:** Handle products, retrieve products for specific orders.
- **Security:** Secure access to APIs.
- **Cloud Hosting:** Host APIs on Azure for internet access.

## Endpoints

- **Customer Endpoints:**
  - `GET /customers`: Retrieve all customers.
  - `GET /customers/{id}`: Retrieve customer by ID.
  - `POST /customers`: Create a new customer.
  - `PATCH /customers/{id}`: Update an existing customer.
  - `DELETE /customers/{id}`: Delete a customer.
  
- **Order Endpoints:**
  - `GET /orders`: Retrieve all orders.
  - `GET /orders/{id}`: Retrieve order by ID.
  - `POST /orders`: Create a new order.
  - `PATCH /orders/{id}`: Update an existing order.
  - `DELETE /orders/{id}`: Delete an order.
  - `GET /orders/customer/{customerId}`: Retrieve all orders for a specific customer.
  
- **Product Endpoints:**
  - `GET /products`: Retrieve all products.
  - `GET /products/{id}`: Retrieve product by ID.
  - `POST /products`: Create a new product.
  - `PATCH /products/{id}`: Update an existing product.
  - `DELETE /products/{id}`: Delete a product.
  - `GET /products/order/{orderId}`: Retrieve all products for a specific order.

## How to Use

1. Clone this repository to your local machine.
2. Set up your Azure SQL Server and configure your database according to the provided SQL script.
3. Open the project in Visual Studio 2022.
4. Modify the `appsettings.json` file with your Azure SQL Server connection details.
5. Build and run the project.
6. Access the APIs using the provided endpoints.

## Security Note

- Authentication and authorization mechanisms are not implemented in this version. Please ensure to implement proper security measures before deploying to production.

## References

- [Microsoft Docs: Tutorial: Create a web API with ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api)
- [Microsoft Docs: Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [Microsoft Docs: Azure Cloud Hosting](https://docs.microsoft.com/en-us/azure/app-service/)

## Contact

For any questions or inquiries, please contact [Kagiso Setshwane] at [34212728@mynwu.ac.za].

