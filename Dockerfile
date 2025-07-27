# Stage 1: build con .NET 9.0 preview
FROM mcr.microsoft.com/dotnet/sdk:9.0-preview AS build
WORKDIR /src

COPY AguaDulce.sln ./
COPY src/AguaDulce.Web/AguaDulce.Web.csproj src/AguaDulce.Web/
RUN dotnet restore AguaDulce.sln

COPY . .
RUN dotnet publish "src/AguaDulce.Web/AguaDulce.Web.csproj" -c Release -o /app/out

FROM mcr.microsoft.com/dotnet/aspnet:9.0-preview AS runtime
WORKDIR /app

# Escucha en el puerto que venga de PORT o, si no existe, en 5000
ENV ASPNETCORE_URLS=http://*:${PORT:-5000}

COPY --from=build /app/out ./

# EXPOSE es meramente informativo; Railway usa ASPNETCORE_URLS
EXPOSE ${PORT:-5000}

ENTRYPOINT ["dotnet", "AguaDulce.Web.dll"]