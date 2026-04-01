# Course Management API

This is a .NET 8 Web API for managing students, courses, and instructors.

## Technologies Used
* **ASP.NET Core Web API:** The framework used to build the RESTful endpoints.
* **Entity Framework Core (EF Core):** An Object-Relational Mapper (ORM) that allows the code to talk to the database using C# objects.
* **SQL Server:** The relational database management system used to store project data.
* **Swagger (OpenAPI):** A tool that provides interactive documentation and a UI to test the API endpoints.

## Authentication Security: HTTP-Only Cookies
In modern web development, **HTTP-only cookies** are considered an industry standard for authentication security because:
1. **XSS Protection:** They prevent client-side scripts (JavaScript) from accessing the cookie. This means even if a hacker injects a malicious script into the site, they cannot steal the user's session token.
2. **Reduced Attack Surface:** Unlike `localStorage`, which is easily accessible via script, HTTP-only cookies are only sent by the browser during HTTP requests, keeping sensitive tokens hidden from the browser's document object model (DOM).

## API Documentation & Testing
The API endpoints are documented using Swagger. 
* **GET /api/Instructors**: Retrieves a list of all instructors.
* **POST /api/Instructors**: Adds a new instructor to the database.

## How to Run
1. Clone the repository.
2. Run `dotnet ef database update` to create the SQL tables.
3. Run `dotnet run` and go to `/swagger` to test the endpoints.
