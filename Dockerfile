# Базовый образ для выполнения приложения
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Этап сборки
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["BlazorApp1.csproj", "./"]
RUN dotnet restore "./BlazorApp1.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "./BlazorApp1.csproj" -c Release -o /app/build

# Этап публикации
FROM build AS publish
RUN dotnet publish "./BlazorApp1.csproj" -c Release -o /app/publish /p:UseAppHost=false

# Финальная образ для выполнения
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorApp1.dll"]