# Actividad 17 — Entity Framework Core

Aplicación Blazor Web App en .NET 8 para administrar estudiantes con Entity Framework Core y SQL Server.

## Requisitos

- .NET 8 SDK
- SQL Server o SQL Server LocalDB

## Configurar y ejecutar

Desde la carpeta que contiene `Actividad17_EFCore.csproj`:

```bash
dotnet restore
dotnet tool restore
dotnet ef database update
dotnet run
```

La migración inicial está incluida en `Migrations/`. `dotnet ef database update` crea o actualiza la base de datos `ControlEstudiantesDB` usando la conexión configurada en `appsettings.json`.

La cadena de conexión incluida apunta a SQL Server LocalDB. Si usas otra instancia de SQL Server, cambia `ConnectionStrings:DefaultConnection` en `appsettings.json` para que coincida con tu instalación.

Para crear una migración después de cambiar el modelo:

```bash
dotnet ef migrations add NombreDescriptivo
dotnet ef database update
```

## Funcionalidad

- Crear estudiantes.
- Consultar la lista desde SQL Server.
- Editar nombre, correo y calificación.
- Eliminar estudiantes.
- Validar los campos y evitar correos duplicados.

## Entrega

Sube la solución completa al repositorio GitHub, incluyendo `Migrations/`, `dotnet-tools.json` y `Specs/`. No subas contraseñas ni credenciales privadas.
