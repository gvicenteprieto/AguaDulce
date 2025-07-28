# AguaDulce Servicios Editoriales  

[![Release](https://img.shields.io/github/v/release/gvicenteprieto/AguaDulce?label=release)](https://github.com/gvicenteprieto/AguaDulce/releases)
---

## Contenidos

- [Descripcion](#descripcion)  
- [Tecnologias](#tecnologias)  
- [Requisitos previos](#requisitos-previos)  
- [Instalacion](#instalacion)  
- [Uso local](#uso-local)  
- [Despliegue](#despliegue)  
- [Estructura de directorios](#estructura-de-directorios)  
- [Contribucion](#contribucion)  
- [Licencia](#licencia)  

---

## Descripcion



---

## Tecnologias

- .NET 6  
- ASP.NET Core MVC  
- Entity Framework Core  
- SQL Server  
- JavaScript / SASS  
- Swagger (OpenAPI) para documentacion de API  

---

## Requisitos previos

- [.NET 6 SDK](https://dotnet.microsoft.com/download)  
- SQL Server (o cadena de conexion a servidor compatible)  
- Node.js (para tareas de front-end, opcional)  
- Git  

---

## Instalacion

Clona el repositorio y prepara el entorno local:

```bash
git clone https://github.com/gvicenteprieto/AguaDulce.git
cd AguaDulce

dotnet restore

dotnet ef database update --project src/AguaDulce