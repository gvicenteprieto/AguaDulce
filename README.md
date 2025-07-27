# AguaDulce Servicios Editoriales  

![AguaDulce Logo](https://raw.githubusercontent.com/gvicenteprieto/AguaDulce/main/src/AguaDulce/wwwroot/img/logo.png)
---

## Contenidos

- [Descripción](#descripción)  
- [Tecnologías](#tecnologías)  
- [Requisitos previos](#requisitos-previos)  
- [Instalación](#instalación)  
- [Uso local](#uso-local)  
- [Despliegue](#despliegue)  
- [Estructura de directorios](#estructura-de-directorios)  
- [Contribución](#contribución)  
- [Licencia](#licencia)  

---

## Descripción



---

## Tecnologías

- .NET 6  
- ASP.NET Core MVC  
- Entity Framework Core  
- SQL Server  
- JavaScript / SASS  
- Swagger (OpenAPI) para documentación de API  

---

## Requisitos previos

- [.NET 6 SDK](https://dotnet.microsoft.com/download)  
- SQL Server (o cadena de conexión a servidor compatible)  
- Node.js (para tareas de front-end, opcional)  
- Git  

---

## Instalación

Clona el repositorio y prepara el entorno local:

```bash
git clone https://github.com/gvicenteprieto/AguaDulce.git
cd AguaDulce

dotnet restore

dotnet ef database update --project src/AguaDulce