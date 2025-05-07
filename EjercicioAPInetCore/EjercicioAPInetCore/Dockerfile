# Build stage
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src
COPY ["EjercicioAPInetCore.csproj", "./"]
RUN dotnet restore "EjercicioAPInetCore.csproj"
COPY . .
RUN dotnet publish "EjercicioAPInetCore.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /app
COPY --from=build /app/publish .
ENTRYPOINT ["dotnet", "EjercicioAPInetCore.dll"]
