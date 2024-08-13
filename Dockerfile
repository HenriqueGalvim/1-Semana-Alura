# Base image with .NET 8 SDK for building
FROM mcr.microsoft.com/dotnet/sdk:8.0-alpine AS build
WORKDIR /app

# Copy the project files
COPY . .

# Restore dependencies
RUN dotnet restore

# Build the application
RUN dotnet publish -c Release -o /app/publish

# Base image with .NET 8 Runtime for running
FROM mcr.microsoft.com/dotnet/runtime:8.0-alpine
WORKDIR /app

# Copy the published application
COPY --from=build /app/publish .

# Define the entrypoint for the container
ENTRYPOINT ["dotnet", "praticaALuraCerto.dll"]