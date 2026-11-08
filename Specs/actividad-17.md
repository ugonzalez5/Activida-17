# Actividad 17: Configuración e implementación de Entity Framework Core

## Objetivo
Configurar e implementar Entity Framework Core en el proyecto Blazor para persistir los datos de estudiantes en SQL Server y habilitar operaciones CRUD.

## Implementación incluida
- Paquetes NuGet de EF Core y proveedor SQL Server en el archivo `.csproj`.
- Modelo `Estudiante` con validaciones.
- `ApplicationDbContext` con `DbSet<Estudiante>` y configuración de tabla, campos e índice único para correo.
- Cadena de conexión en `appsettings.json`.
- Registro de `IDbContextFactory<ApplicationDbContext>` en `Program.cs`.
- Componente Blazor con operaciones de crear, consultar, actualizar y eliminar.

## Migraciones
Ejecutar en la terminal:

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

## Entregable
Subir la solución completa a un repositorio GitHub y compartir la liga.
