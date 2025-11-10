# Dockerfile for OpslyApi
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/OpslyApi/OpslyApi.csproj", "OpslyApi/"]
RUN dotnet restore "OpslyApi/OpslyApi.csproj"
COPY src/OpslyApi/. OpslyApi/
WORKDIR "/src/OpslyApi"
RUN dotnet build "OpslyApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "OpslyApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "OpslyApi.dll"]
