# BibliotecaMVC

## Descripción del proyecto
Esta es una aplicación web simple de gestión de biblioteca desarrollada con **ASP.NET Core MVC**. Permite a los usuarios gestionar libros y autores en una base de datos SQL Server, con la posibilidad de agregar nuevos libros y autores a través de formularios.

## Tecnologías utilizadas
- **ASP.NET Core MVC**: Framework principal para la aplicación web.
- **Entity Framework Core**: ORM utilizado para interactuar con la base de datos.
- **SQL Server**: Base de datos utilizada para almacenar los datos de libros y autores.
- **Bootstrap**: Framework CSS para el diseño visual de la aplicación.
- **Visual Studio 2022**: Entorno de desarrollo.

## Funcionalidades
- Listar todos los libros disponibles.
- ![image](https://github.com/user-attachments/assets/65452e88-05ae-41b1-bba9-f7de4246ba2e)
- Añadir nuevos libros a la biblioteca seleccionando autores de una lista desplegable.
- ![image](https://github.com/user-attachments/assets/206d46c3-b037-44fc-897e-e416d9fd621a)
- Listar todos los autores disponibles.
- ![image](https://github.com/user-attachments/assets/a6238b21-4d55-4c6e-960a-8f0df53ab05b)
- Añadir nuevos autores al sistema.
- ![image](https://github.com/user-attachments/assets/4a00e6a0-e817-41e3-aef7-74b7eb8afbba)
- Validación de formularios para asegurar la entrada correcta de los datos.
-![image](https://github.com/user-attachments/assets/ce5f34d3-d380-4d68-928a-f92456d7bfd9)
-![image](https://github.com/user-attachments/assets/62a62974-2e23-456d-8485-276ae9ec5fcc)

## Pasos para configurar y ejecutar la aplicación

## Requisitos Previos
- **Visual Studio 2022** instalado.
- **SQL Server** en ejecución y configurado.

## Pasos para Clonar y Configurar la Aplicación

### 1. Clonar el Repositorio
1. Abre **Visual Studio 2022**.
2. Ve a **Archivo** > **Abrir** > **Repositorio de Git**.
3. Ingresa la URL del repositorio de GitHub y haz clic en **Clonar**.

### 2. Abrir el Proyecto
1. Una vez clonado el repositorio, abre la solución (archivo `.sln`) del proyecto.

### 3. Ejecutar el Script de la Base de Datos
1. Abre SQL Server Management Studio (SSMS).
2. Conéctate a tu instancia de SQL Server.
3. Crea una nueva base de datos o selecciona una existente.
4. Abre el script de la base de datos que se incluye en el repositorio (por ejemplo, `script.sql`).
5. Ejecuta el script para crear las tablas y relaciones necesarias en tu base de datos.

### 4. Verificar Instalación de Entity Framework Core
1. Abre la **Consola del Administrador de Paquetes** desde **Herramientas** > **Administrador de paquetes NuGet** > **Consola del Administrador de Paquetes**.
2. Verifica si Entity Framework Core está instalado ejecutando el siguiente comando:
`Get-Package | Where-Object { $_.Id -eq 'Microsoft.EntityFrameworkCore' }`
   
### 5. Instalar Entity Framework Core (si es necesario)
Si Entity Framework Core no está instalado, ejecuta los siguientes comandos en la Consola del Administrador de Paquetes:
`Install-Package Microsoft.EntityFrameworkCore.SqlServer`
`Install-Package Microsoft.EntityFrameworkCore.Tools`

### 6. Ejecutar la Aplicación
1. Una vez que todo esté configurado, presiona Ctrl + F5 o haz clic en el botón Iniciar en Visual Studio para ejecutar la aplicación.
2. La aplicación se abrirá en tu navegador predeterminado, y deberías ver la página de inicio de tu aplicación ASP.NET Core."

##Diagrama Modelo Entidad Relación
![image](https://github.com/user-attachments/assets/b8901826-5c12-42d2-a8b4-a183dbb43d09)

