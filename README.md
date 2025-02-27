# TechLibrary API

A comprehensive digital library management system API developed during Rocketseat's NLW C# track. This project showcases a well-structured architecture following modern backend development practices.

## Project Structure

The solution follows clean architecture principles with clear separation of concerns:

- **Controllers**: Handle HTTP requests (Books, Checkouts, Login, Users)
- **Domain**: Contains business entities (Book, Checkout, User)
- **Filters**: Custom exception handling
- **Infrastructure**: Database context and data access
- **Security**: JWT authentication and password encryption
- **Services**: Business logic implementations
- **UseCases**: Application logic organized by feature

## Features

- **User Management**:
  - Registration with validation
  - Authentication using JWT tokens
  - Secure password encryption

- **Book Management**:
  - Listing with pagination
  - Advanced filtering options
  - Complete checkout flow

- **Security**:
  - JWT-based authentication
  - Custom cryptography implementation
  - Robust exception handling

## Technical Stack

- C# and .NET
- Entity Framework Core
- JWT for authentication
- Swagger for API documentation
- Repository pattern
- Clean architecture

## Exception Handling

The application implements a comprehensive exception handling system with custom exceptions:
- ConflictException
- ErrorOnValidationException
- InvalidLoginException
- NotFoundException
- TechLibraryException


## Acknowledgments

Special thanks to Rocketseat and Wellison Arley for providing this learning opportunity during the NLW event.
