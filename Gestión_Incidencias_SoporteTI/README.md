# Sistema de Gestión de Incidencias de Soporte TI

Aplicación de consola desarrollada en **C#** para registrar, consultar,
filtrar y dar seguimiento a incidencias de soporte técnico relacionadas
con Hardware, Software y Red.

## Descripción

El proyecto simula una herramienta básica para que un equipo de soporte
de TI organice reportes de empleados. Cada incidencia contiene
información general y un dato específico según el tipo de problema.

## Funcionalidades

-   Registrar incidencias de Hardware, Software y Red.
-   Comprobar que no se repita un identificador durante el registro.
-   Mostrar todas las incidencias registradas.
-   Buscar por identificador o nombre del empleado.
-   Filtrar por prioridad, estado y tipo.
-   Cambiar el estado respetando reglas de transición.
-   Mostrar estadísticas por estado, prioridad y tipo.
-   Calcular porcentajes de incidencias por estado.
-   Limitar la cantidad de incidencias según la capacidad definida en el
    programa.

## Menú principal

1.  Registrar incidencia.
2.  Mostrar todas las incidencias.
3.  Buscar por identificador.
4.  Buscar por empleado.
5.  Filtrar por prioridad.
6.  Filtrar por estado.
7.  Filtrar por tipo.
8.  Cambiar estado de incidencia.
9.  Mostrar estadísticas.
10. Salir.

## Tipos de incidencia

-   **Hardware:** incluye el dato específico `EquipoAfectado`.
-   **Software:** incluye el dato específico `AplicacionAfectada`.
-   **Red:** incluye el dato específico `RecursoAfectado`.

Las tres clases derivan de `Incidencia` y utilizan la interfaz
`IProcesable`.

## Datos generales

La clase base `Incidencia` maneja los siguientes datos:

-   `Identificador`
-   `NombreIncidencia`
-   `NombreEmpleado`
-   `Descripcion`
-   `Prioridad`
-   `Estado`

Las prioridades solicitadas son Baja, Media, Alta y Crítica. Los estados
contemplados son Abierta, En Proceso y Resuelta.

## Reglas de cambio de estado

-   **Abierta** puede pasar a **En Proceso**.
-   **En Proceso** puede pasar a **Resuelta**.
-   No se permite pasar directamente de **Abierta** a **Resuelta**.
-   No se permite regresar de **En Proceso** a **Abierta**.
-   Una incidencia **Resuelta** no puede cambiar de estado mediante el
    flujo implementado.
-   No se realiza un cambio si el estado nuevo es igual al actual.

## Tecnologías y conceptos

-   C#
-   Aplicación de consola
-   Programación Orientada a Objetos (POO)
-   Clases y objetos
-   Herencia y sobrescritura de métodos (`override`)
-   Interfaces
-   Arreglos de objetos
-   Métodos estáticos
-   Parámetros por referencia con `ref`
-   Condicionales, ciclos y `switch`
-   Búsqueda y filtrado
-   Estadísticas y porcentajes

## Estructura del proyecto

``` text
SistemaGestionIncidencias/
├── Program.cs
├── GestorIncidencias.cs
├── Incidencia.cs
├── IncidenciaHardware.cs
├── IncidenciaSoftware.cs
├── IncidenciaRed.cs
└── IProcesable.cs
```

Esta es una estructura sugerida según las clases utilizadas. Ajusta los
nombres de los archivos si tu proyecto real está organizado de otra
manera.

### Responsabilidades principales

-   **`Program.cs`:** inicia la aplicación, mantiene el ciclo del menú y
    dirige cada opción al método correspondiente.
-   **`GestorIncidencias.cs`:** concentra el registro, las consultas,
    las búsquedas, los filtros, los cambios de estado y las
    estadísticas.
-   **`Incidencia.cs`:** define los datos y el comportamiento común.
-   **`IncidenciaHardware.cs`:** representa una incidencia de Hardware.
-   **`IncidenciaSoftware.cs`:** representa una incidencia de Software.
-   **`IncidenciaRed.cs`:** representa una incidencia de Red.
-   **`IProcesable.cs`:** declara el contrato para procesar una
    incidencia.

## Requisitos

-   SDK de .NET compatible con el proyecto.
-   Visual Studio o Visual Studio Code, u otro entorno compatible.
-   Los archivos fuente incluidos en un proyecto de consola de C#.

## Cómo ejecutar

1.  Abre el proyecto en Visual Studio o Visual Studio Code.
2.  Verifica que las clases y la interfaz estén incluidas en el
    proyecto.
3.  Compila el proyecto y corrige los errores que aparezcan.
4.  Ejecuta la aplicación y selecciona una opción del menú.

Desde la terminal, en la carpeta que contiene el archivo `.csproj`,
puedes ejecutar:

``` bash
dotnet run
```

Este comando requiere un proyecto .NET válido con su archivo `.csproj`.

## Ejemplo de uso

1.  Selecciona **1. Registrar incidencia**.
2.  Captura el identificador y los datos generales.
3.  Elige Hardware, Software o Red.
4.  Captura el dato específico solicitado para ese tipo.
5.  Busca la incidencia o consulta todas las incidencias.
6.  Cambia su estado para dar seguimiento.
7.  Consulta las estadísticas desde la opción 9.

## Posibles mejoras

-   Guardar incidencias en archivos o una base de datos.
-   Agregar edición y eliminación de incidencias.
-   Registrar fechas de creación y resolución.
-   Asignar un técnico responsable.
-   Fortalecer las validaciones de entrada.
-   Incorporar pruebas unitarias.
-   Crear una interfaz gráfica o una API.
-   Exportar reportes.

## Objetivo de aprendizaje

Practicar la organización de una aplicación de consola, la reutilización
de código mediante herencia, el uso de interfaces y la implementación de
reglas de negocio para administrar información.

## Autor

**\[Tu nombre\]**

## Repositorio

**\[Agrega aquí el enlace de tu repositorio de GitHub\]**
