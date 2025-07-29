# 1. Build con SDK .NET 8
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY AguaDulce.sln ./
COPY src/AguaDulce.Web/AguaDulce.Web.csproj src/AguaDulce.Web/
RUN dotnet restore AguaDulce.sln

COPY . .
RUN dotnet publish src/AguaDulce.Web/AguaDulce.Web.csproj \
    -c Release -o /app/out

# 2. Runtime con ASP.NET 8
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app

# Define el puerto por la variable PORT (o 5000 por defecto)
ENV PORT=5000
ENV ASPNETCORE_URLS=http://*:$PORT

COPY --from=build /app/out ./

EXPOSE ${PORT}

# ENTRYPOINT que respeta PORT en runtime
ENTRYPOINT ["bash", "-lc", "exec dotnet AguaDulce.Web.dll --urls=http://*:$PORT"]