# CMPG323-Project2-34212728

# EcoPower Logistics API Project

The EcoPower Logistics API project repository. This project aims to create a set of RESTful APIs for managing solar energy products and logistics operations.
# EcoPower Logistics API Documentation

Welcome to the EcoPower Logistics CRUD RESTful API documentation. This API provides endpoints to manage logistics data for solar energy systems.

## Table of Contents

- [Overview](#overview)
- [Prerequisites](#prerequisites)
- [Requirements](#requirements)
- [Endpoints](#endpoints)
- [Authentication](#authentication)
- [Getting Started](#getting-started)
- [Usage Examples](#usage-examples)
- [Security Considerations](#security-considerations)
- [References](#references)

## Overview

EcoPower Logistics sells solar energy system components and offers comprehensive logistics solutions. This project involves creating a CRUD RESTful API to manage logistics data related to customers, orders, and products.

## Prerequisites

- Access to NWU Azure tenant with a valid account (e.g., 12345678@student365.msfed.nwu.ac.za).
- Azure resource group with an appropriate naming convention.
- Visual Studio 2022 Community edition and .NET Core 6 installed.

## Requirements

The API project involves creating various endpoints for managing customers, orders, and products. Each resource has GET, POST, PATCH, and DELETE methods. Detailed requirements can be found in the [project description](#project-description).

## Endpoints

### Customers

- `GET /api/customers`: Get all customers.
- `GET /api/customers/{id}`: Get a specific customer by ID.
- `POST /api/customers`: Create a new customer.
- `PATCH /api/customers/{id}`: Update an existing customer.
- `DELETE /api/customers/{id}`: Delete a customer.

### Orders

- `GET /api/orders`: Get all orders.
- `GET /api/orders/{id}`: Get a specific order by ID.
- `POST /api/orders`: Create a new order.
- `PATCH /api/orders/{id}`: Update an existing order.
- `DELETE /api/orders/{id}`: Delete an order.

### Products

- `GET /api/products`: Get all products.
- `GET /api/products/{id}`: Get a specific product by ID.
- `POST /api/products`: Create a new product.
- `PATCH /api/products/{id}`: Update an existing product.
- `DELETE /api/products/{id}`: Delete a product.

## Authentication

The API is secured using JWT authentication. You must include a valid JWT token in the `Authorization` header for authenticated requests.

## Getting Started

1. Clone this repository to your local machine.
2. Install required dependencies using `dotnet restore`.
3. Configure the connection string in `appsettings.json` to connect to your database.
4. Run the application using `dotnet run`.

# Azure Link:
https://portal.azure.com/#@nwuac.onmicrosoft.com/resource/subscriptions/dedd55cf-6843-4801-ad00-90a6ba942168/resourceGroups/Ap1-project2/overview

# API Link:
https://localhost:7185/swagger/index.html
and it works while the code is running on Visual Studio 2022 and the file you will find it on the master BRANCH where it has code to the methods

## Contact

For any questions or inquiries, please contact [Kagiso Setshwane] at [34212728@mynwu.ac.za].

# References

1. Microsoft. (n.d.). Tutorial: Create a web API with ASP.NET Core. Microsoft Docs. URL: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api

2. Microsoft. (n.d.). Create a web API with ASP.NET Core controllers - Learn. Microsoft Docs. URL: https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-5.0

3. Microsoft. (n.d.). ASP.NET Core web API documentation with Swagger / OpenAPI. Microsoft Docs. URL: https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger

4. Microsoft. (n.d.). Entity Framework Core 3.1 - Getting Started. Microsoft Docs. URL: https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli

5. Microsoft. (n.d.). Join two entities in .NET Core, using lambda and Entity Framework Core. Microsoft Docs. URL: https://docs.microsoft.com/en-us/ef/core/querying/related-data

6. Microsoft. (n.d.). Publish an ASP.NET Core web API to Azure API Management with Visual Studio. Microsoft Docs. URL: https://docs.microsoft.com/en-us/azure/api-management/how-to-create-service-instance-portal

7. GitHub. (n.d.). Automating ASP.NET Core Web API Creation That Communicates with Your Database in 60 Seconds or Less. URL: https://github.com/dotnet-presentations/aspnetcore-app-workshop

8. LinkedIn Groups. (n.d.). URL: https://www.linkedin.com/groups/

9. Stack Overflow. (n.d.). URL: https://stackoverflow.com/

10. Microsoft Developer Community User Groups. (n.d.). URL: https://developer.microsoft.com/en-us/community/user-groups

11. YouTube Microsoft Development Influencers. (n.d.). URL: https://www.youtube.com/results?search_query=microsoft+development+tutorials

12. Azure Key Vault. (n.d.). URL: https://azure.microsoft.com/en-us/services/key-vault/

13. JWT Authentication in ASP.NET Core. (n.d.). Microsoft Docs. URL: https://docs.microsoft.com/en-us/aspnet/core/security/authentication/jwt

14. Microsoft. (n.d.). Using the Entity Framework Core Tools. Microsoft Docs. URL: https://docs.microsoft.com/en-us/ef/core/cli/

15. HashiCorp Vault. (n.d.). URL: https://www.vaultproject.io/

16. Azure Portal. (n.d.). URL: https://portal.azure.com/

17. Microsoft. (n.d.). Learn about the different authentication options for your APIs. Microsoft Docs. URL: https://docs.microsoft.com/en-us/azure/api-management/api-management-howto-protect-backend-with-aad

18. GitHub. (n.d.). Best practices for using Azure SDKs in untrusted environments. URL: https://github.com/Azure/azure-sdk-for-net#best-practices-for-using-azure-sdks-in-untrusted-environments

19. Microsoft Docs. (n.d.). Introduction to API Management. URL: https://docs.microsoft.com/en-us/azure/api-management/api-management-key-concepts

20. Microsoft Docs. (n.d.). Create a web API with ASP.NET Core and Visual Studio Code. URL: https://docs.microsoft.com/en-us/aspnet/core/tutorials/web-api-vsc

21. Microsoft Docs. (n.d.). Consuming web APIs - Learn | Microsoft Docs. URL: https://docs.microsoft.com/en-us/learn/modules/consume-web-apis/

22. Microsoft Docs. (n.d.). Introduction to Azure API Management. URL: https://docs.microsoft.com/en-us/learn/modules/intro-to-api-management/

23. Microsoft Docs. (n.d.). Best practices for securing your API. URL: https://docs.microsoft.com/en-us/azure/api-management/security-best-practices

24. Microsoft Docs. (n.d.). Create a REST API using HTTP APIs in API Gateway - Learn | Microsoft Docs. URL: https://docs.microsoft.com/en-us/learn/modules/create-a-rest-api-using-http-apis/

25. Microsoft Docs. (n.d.). RESTful API design. URL: https://docs.microsoft.com/en-us/azure/architecture/best-practices/api-design

26. Microsoft Docs. (n.d.). Building an Application with a Web API. URL: https://docs.microsoft.com/en-us/dotnet/architecture/microservices/multi-container-microservice-net-applications/web-api-design

27. Microsoft Docs. (n.d.). Authentication and authorization for microservices in Azure Kubernetes Service (AKS). URL: https://docs.microsoft.com/en-us/azure/aks/use-multiple-node-pools#authenticate-microservices

28. Microsoft Docs. (n.d.). REST API concepts and examples. URL: https://docs.microsoft.com/en-us/azure/architecture/best-practices/api-design

29. Microsoft Docs. (n.d.). Tutorial: Create a .NET class library with Visual Studio Code. URL: https://docs.microsoft.com/en-us/dotnet/core/tutorials/library-with-visual-studio-code

30. Microsoft Docs. (n.d.). Create a web API with ASP.NET Core. URL: https://docs.microsoft.com/en-us/learn/modules/create-a-web-api-with-aspnet-core/

31. Microsoft Docs. (n.d.). Implement API request throttling in ASP.NET Core. URL: https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing

32. Microsoft Docs. (n.d.). ASP.NET Core MVC routing. URL: https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/routing

33. Microsoft Docs. (n.d.). Introduction to Azure Resource Manager. URL: https://docs.microsoft.com/en-us/azure/azure-resource-manager/management/overview

34. Microsoft Docs. (n.d.). Introduction to Azure DevOps. URL: https://docs.microsoft.com/en-us/azure/devops/learn/what-is-azure-devops

35. Microsoft Docs. (n.d.). Secure Azure DevOps pipelines. URL: https://docs.microsoft



## Usage Examples

### Creating a new customer

```http
POST /api/customers
Content-Type: application/json

{
  "name": "Eco Solar Inc.",
  "address": "123 Solar Street"
}




