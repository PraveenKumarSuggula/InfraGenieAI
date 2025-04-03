# Base image with ASP.NET runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Build image with .NET SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY ["src/CicdGeneratorService/CicdGeneratorService.csproj", "src/CicdGeneratorService/"]
RUN dotnet restore "src/CicdGeneratorService/CicdGeneratorService.csproj"

COPY . .
WORKDIR "/src/src/CicdGeneratorService"
RUN dotnet publish "CicdGeneratorService.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Final runtime image
FROM base AS final
WORKDIR /app
COPY --from=build /app/publish .

# Set ASP.NET to listen on port 8080 only (no HTTPS)
ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Development

ENTRYPOINT ["dotnet", "CicdGeneratorService.dll"]
