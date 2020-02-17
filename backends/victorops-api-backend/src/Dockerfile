FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

# Restore only
FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build

COPY src/service/*.csproj /all/src/service/
COPY src/clients/netstandard/src/Org.OpenAPITools/*.csproj /all/src/clients/netstandard/src/Org.OpenAPITools/

WORKDIR /all/src/service/
RUN dotnet restore 

WORKDIR /all/src/clients/netstandard/src/Org.OpenAPITools/
RUN dotnet restore

# Build Source Code
COPY src/service /all/src/service/
COPY src/clients/netstandard/src/Org.OpenAPITools /all/src/clients/netstandard/src/Org.OpenAPITools/
WORKDIR /all/src/service/
RUN dotnet build --no-restore -c Release -o /app

#WORKDIR /all/tests/Unit
#RUN dotnet test --no-restore 

FROM build AS publish
RUN dotnet publish --no-restore -c Release -o /app

# Build runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app .
EXPOSE 80
ENTRYPOINT ["dotnet", "VictorOpsBackendApi.dll"]