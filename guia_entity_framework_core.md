# Guía de instalación y configuración de Entity Framework Core

## 1. Instalar los paquetes NuGet

**Importante:** La versión principal de Entity Framework Core debe coincidir con la versión principal de .NET que estamos utilizando.

Por ejemplo:
- **.NET 8.0** → Entity Framework Core **8.x**
- **.NET 9.0** → Entity Framework Core **9.x**

Se recomienda seleccionar la última versión estable disponible dentro de esa versión principal.

### En la capa DAL

En Visual Studio, hacer clic derecho sobre el proyecto **DAL → Administrar paquetes NuGet** e instalar:

- `Microsoft.EntityFrameworkCore.SqlServer`
- `Microsoft.EntityFrameworkCore.Tools`
- `Microsoft.EntityFrameworkCore.Design`

### En la capa UI

Hacer clic derecho sobre el proyecto **UI → Administrar paquetes NuGet** e instalar:

- `Microsoft.EntityFrameworkCore.Design`

## 2. Generar las clases de Entity Framework desde la base de datos

Abrir **Herramientas → Administrador de paquetes NuGet → Consola del Administrador de paquetes** en Visual Studio y ejecutar:

```powershell
Scaffold-DbContext 'Server=GONZA\SQLEXPRESS;Database=ModeloParcial;Trusted_Connection=True;TrustServerCertificate=True' Microsoft.EntityFrameworkCore.SqlServer -Project DAL -StartupProject UI -OutputDir Models -Context ModeloParcialContext -NoPluralize
```

Este comando genera automáticamente el contexto y las clases correspondientes a las tablas de la base de datos.

**Antes de ejecutarlo:** reemplazar `GONZA\SQLEXPRESS` por el nombre de su servidor SQL Server y `ModeloParcial` por el nombre de su base de datos.

- `-Project DAL`: genera los archivos en la capa DAL.
- `-StartupProject UI`: utiliza UI como proyecto de inicio.
- `-OutputDir Models`: guarda los archivos generados en la carpeta `Models`.
- `-Context ModeloParcialContext`: establece el nombre del contexto.
- `-NoPluralize`: evita la pluralización automática de los nombres.

## 3. Configurar la cadena de conexión

Verificar la cadena de conexión definida en el archivo `App.config` del proyecto UI.

Si no está incluido, agregar el siguiente parámetro:

`TrustServerCertificate=True`

Esto permite evitar problemas de validación del certificado SSL al conectarnos a SQL Server en nuestro entorno de desarrollo.

## 4. Organizar las entidades en la capa Entity

Para diferenciar nuestras entidades de negocio de las clases generadas por Entity Framework:

1. **Renombrar las entidades de negocio** agregando el sufijo `Entity`. Ejemplo: `Entrada` → `EntradaEntity`.
2. **Mover las clases generadas por EF** a la capa `Entity`. Se recomienda crear una carpeta `EFModel` y colocar allí las clases que representan las tablas de la base de datos. **No mover el contexto**, que debe permanecer en DAL.
3. **Actualizar los namespaces** de las clases generadas por EF a `Entity.EFModel`.

De esta manera, las entidades de negocio quedan diferenciadas de las utilizadas para el acceso a datos.

## 5. Configurar el contexto de Entity Framework

En **DAL → Models**, buscar la clase de contexto generada automáticamente (por ejemplo, `ModeloParcialContext`).

1. Reemplazar la cadena de conexión escrita directamente en el código (*hardcodeada*) por la lectura de la cadena configurada en `App.config`, utilizando `ConfigurationManager`.
2. Agregar el `using` correspondiente a las entidades de EF:

   ```csharp
   using Entity.EFModel;
   ```

3. Verificar que el contexto siga reconociendo correctamente todas las entidades.

**Nota:** Para usar `ConfigurationManager` en .NET 8, instalar `System.Configuration.ConfigurationManager` en el proyecto que lo utiliza. El contexto debe permanecer en DAL.

## 6. Desarrollar los Mappers

Los **Mappers** permiten convertir objetos entre nuestras entidades de negocio y las clases generadas por Entity Framework.

Por cada entidad, desarrollar inicialmente dos métodos:

**De Entity Framework a Entity:**

```csharp
public static EntradaEntity Map(Entrada entrada)
```

**De Entity a Entity Framework:**

```csharp
public static Entrada Map(EntradaEntity entrada)
```

Cada método debe copiar las propiedades correspondientes de un objeto al otro. Así podemos trabajar con nuestras entidades de negocio sin depender directamente de las clases generadas por EF.

## 7. Implementar el acceso a datos (DAL)

1. Utilizar el contexto de Entity Framework para acceder a la base de datos.
2. Reemplazar las consultas ADO.NET por operaciones realizadas mediante EF.
3. Utilizar los **Mappers** para convertir los objetos antes de devolverlos a la capa BLL o guardarlos en la base de datos.
4. Mantener la lógica de acceso a datos dentro de DAL, respetando la arquitectura en capas.

## Resultado esperado

- **UI:** Interfaz de usuario y configuración de la aplicación.
- **BLL:** Lógica de negocio.
- **DAL:** Acceso a datos mediante Entity Framework, contexto y mappers.
- **Entity:** Entidades de negocio (`EntradaEntity`) y entidades de EF (`EFModel/Entrada`).

**Objetivo:** Incorporar Entity Framework Core sin modificar la arquitectura en capas que venimos utilizando, reemplazando principalmente la forma en que accedemos a la base de datos.
