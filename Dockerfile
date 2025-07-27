# Stage 1: build con .NET 9.0 preview
FROM mcr.microsoft.com/dotnet/sdk:9.0-preview AS build
WORKDIR /src

COPY AguaDulce.sln ./
COPY src/AguaDulce.Web/AguaDulce.Web.csproj src/AguaDulce.Web/
RUN dotnet restore AguaDulce.sln

COPY . .
RUN dotnet publish "src/AguaDulce.Web/AguaDulce.Web.csproj" -c Release -o /app/out

# Stage 2: runtime con .NET 9.0 preview
FROM mcr.microsoft.com/dotnet/aspnet:9.0-preview AS runtime
ENV ASPNETCORE_URLS=http://+:5000

WORKDIR /app
COPY --from=build /app/out ./
EXPOSE 5000

ENTRYPOINT ["dotnet", "AguaDulce.Web.dll"]