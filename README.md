# JWTSecurity.API

A modern ASP.NET Core Web API demonstrating secure authentication and authorization using JWT (JSON Web Tokens) and refresh tokens. This project is ideal for learning or as a starting point for production-ready authentication systems.

## Features

- User registration and login with hashed passwords
- JWT-based authentication for stateless security
- Refresh token mechanism for seamless token renewal
- Role-based authorization (e.g., Admin-only endpoints)
- Entity Framework Core with SQL Server for user persistence
- Clean, minimal, and extensible codebase
- OpenAPI (Scalar) support for easy API exploration

## Endpoints

- `POST /api/auth/register` — Register a new user
- `POST /api/auth/login` — Authenticate and receive JWT + refresh token
- `POST /api/auth/refresh-token` — Obtain new JWT using a valid refresh token
- `GET /api/auth` — Authenticated users only
- `GET /api/auth/admin-only` — Admin role required

## Getting Started

### Prerequisites
- [.NET 9 SDK](https://dotnet.microsoft.com/download)
- SQL Server instance (local or remote)

### Configuration
1. Clone the repository.
2. Update `appsettings.Development.json` or `appsettings.json`:
   - Set your SQL Server connection string under `ConnectionStrings:SqlServer`.
   - Set `AppSettings:Token` to a strong secret key.
   - Optionally set `AppSettings:Issuer` and `AppSettings:Audience`.

Example:
```json
"ConnectionStrings": {
  "SqlServer": "YourSqlServerConnectionString"
},
"AppSettings": {
  "Token": "your-very-strong-secret-key",
  "Issuer": "JWTSecurityAPI",
  "Audience": "JWTSecurityClient"
}
```

### Database
Run EF Core migrations to create the database:

```bash
dotnet ef migrations add InitialCreate
```

Then update the database:

```bash
dotnet ef database update
```

### Running the API
```bash
dotnet run
```
The API will be available at `http://localhost:5004` (or as configured).

### API Documentation
OpenAPI/Scalar UI is available in development mode at `/scalar/v1` or `/openapi`.


