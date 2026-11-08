# Actividad 17 — Entity Framework Core

Proyecto Blazor Web App (.NET 8) para administrar estudiantes usando Entity Framework Core y SQL Server.

## Requisitos

- .NET 8 SDK
- SQL Server o SQL Server LocalDB
- Visual Studio 2022 o Visual Studio Code

## 1. Configurar la conexión

Edita `appsettings.json`. La cadena incluida utiliza SQL Server LocalDB:

```json
"DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=ControlEstudiantesDB;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True"
```

Si utilizas SQL Server Express, puedes cambiarla, por ejemplo, por:

```text
Server=.\\SQLEXPRESS;Database=ControlEstudiantesDB;Trusted_Connection=True;TrustServerCertificate=True
```

Ajusta el nombre del servidor a la instalación de tu computadora.

## 2. Restaurar paquetes

Abre una terminal en la carpeta donde está `Actividad17_EFCore.csproj` y ejecuta:

```bash
dotnet restore
```

Los paquetes `Microsoft.EntityFrameworkCore.SqlServer` y `Microsoft.EntityFrameworkCore.Design` están declarados en el `.csproj`.

## 3. Instalar la herramienta de migraciones

```bash
dotnet tool install --global dotnet-ef --version 8.0.11
```

Si ya está instalada:

```bash
dotnet tool update --global dotnet-ef --version 8.0.11
```

## 4. Crear y aplicar la migración

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

Estos comandos generan la carpeta `Migrations`, crean la migración inicial y crean la base de datos/tablas en SQL Server.

## 5. Ejecutar

```bash
dotnet run
```

Abre la dirección HTTPS que aparezca en la terminal.

## Funcionalidad CRUD

- **Create:** registrar un estudiante.
- **Read:** consultar la lista desde SQL Server.
- **Update:** seleccionar “Editar”, modificar datos y guardar cambios.
- **Delete:** eliminar un registro.

La aplicación utiliza `IDbContextFactory<ApplicationDbContext>` para crear un contexto por operación, adecuado para componentes Blazor Server interactivos.

## Estructura

```text
Actividad17_EFCore/
├── Components/
│   ├── App.razor
│   ├── Routes.razor
│   └── Pages/
│       └── Home.razor
├── Data/
│   └── ApplicationDbContext.cs
├── Models/
│   └── Estudiante.cs
├── wwwroot/css/app.css
├── appsettings.json
├── Program.cs
└── Actividad17_EFCore.csproj
```

## Nota para entregar

Después de ejecutar `dotnet ef migrations add InitialCreate`, incluye la carpeta `Migrations` generada en el repositorio GitHub. No subas contraseñas reales ni cadenas de conexión con credenciales privadas.
