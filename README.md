# Course Management API

This is a .NET 8 Web API for managing students, courses, and instructors.

## Features
* **Entity Framework Core:** Connected to SQL Server (LocalDB).
* **Swagger UI:** For testing API endpoints.
* **Database:** CourseManagementDB.

## How to Run
1. Clone the repository.
2. Update `appsettings.json` with your SQL connection string.
3. Run `dotnet ef database update` to create the tables.
4. Run `dotnet run` and navigate to `/swagger` in your browser.
