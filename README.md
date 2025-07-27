# AguaDulce Servicios Editoriales  

![AguaDulce Logo](https://raw.githubusercontent.com/gvicenteprieto/AguaDulce/main/src/AguaDulce/wwwroot/img/logo.png)
---

## Contenidos

- [Descripci�n](#descripci�n)  
- [Tecnolog�as](#tecnolog�as)  
- [Requisitos previos](#requisitos-previos)  
- [Instalaci�n](#instalaci�n)  
- [Uso local](#uso-local)  
- [Despliegue](#despliegue)  
- [Estructura de directorios](#estructura-de-directorios)  
- [Contribuci�n](#contribuci�n)  
- [Licencia](#licencia)  

---

## Descripci�n



---

## Tecnolog�as

- .NET 6  
- ASP.NET Core MVC  
- Entity Framework Core  
- SQL Server  
- JavaScript / SASS  
- Swagger (OpenAPI) para documentaci�n de API  

---

## Requisitos previos

- [.NET 6 SDK](https://dotnet.microsoft.com/download)  
- SQL Server (o cadena de conexi�n a servidor compatible)  
- Node.js (para tareas de front-end, opcional)  
- Git  

---

## Instalaci�n

Clona el repositorio y prepara el entorno local:

```bash
git clone https://github.com/gvicenteprieto/AguaDulce.git
cd AguaDulce

dotnet restore

dotnet ef database update --project src/AguaDulce