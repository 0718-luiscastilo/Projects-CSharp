# Sistema de Monitoreo y Mantenimiento Preventivo de Máquinas Industriales

Aplicación de consola desarrollada en **C#** para registrar y administrar información de máquinas industriales. Permite consultar datos operativos, monitorear condiciones de temperatura, actualizar estados y gestionar información relacionada con el mantenimiento preventivo.

## Descripción

El sistema está orientado a un entorno industrial en el que se necesita llevar un control básico de distintas máquinas, como tornos CNC, fresadoras y bandas transportadoras.

La aplicación utiliza programación orientada a objetos para representar los diferentes tipos de máquinas mediante una clase base y clases derivadas.

## Funcionalidades

- Registrar máquinas industriales.
- Mostrar todas las máquinas registradas.
- Monitorear la temperatura y consultar la condición de una máquina.
- Cambiar el estado de una máquina.
- Establecer un intervalo de mantenimiento.
- Modificar las horas de funcionamiento.
- Buscar máquinas por ID.
- Buscar máquinas por estado.
- Consultar estadísticas generales.
- Guardar información en un archivo de texto.
- Cargar información desde un archivo de texto.

## Tipos de máquinas

- **Torno CNC**
- **Fresadora**
- **Banda transportadora**

Cada tipo puede incorporar atributos y comportamientos propios, además de la información común definida en la clase base `MaquinaIndustrial`.

## Tecnologías y conceptos

- C#
- .NET
- Aplicación de consola
- Programación orientada a objetos (POO)
- Clases y objetos
- Herencia y encapsulamiento
- Polimorfismo
- Clases abstractas y métodos sobrescritos
- Arreglos
- Métodos y validación de entradas
- Lectura y escritura de archivos de texto (`StreamReader` y `StreamWriter`)

## Estructura del proyecto

La estructura puede variar según la organización final de los archivos. Los componentes principales contemplados son:

```text
Proyecto/
├── MaquinaIndustrial.cs
├── TornoCNC.cs
├── Fresadora.cs
├── BandaTransportadora.cs
├── Funciones.cs
├── Program.cs
└── maquinas.txt
```

## Ejecución

1. Abre el proyecto en Visual Studio o Visual Studio Code.
2. Verifica que tengas instalado el SDK de .NET compatible con el proyecto.
3. Abre una terminal en la carpeta que contiene el archivo `.csproj`.
4. Ejecuta:

```bash
dotnet run
```

> Si todavía no existe un archivo `.csproj`, crea primero un proyecto de consola de .NET y agrega los archivos fuente.

## Persistencia de datos

El sistema contempla guardar y recuperar registros mediante un archivo de texto llamado `maquinas.txt`. La ubicación del archivo depende del directorio de trabajo desde el que se ejecute la aplicación.

## Objetivo de aprendizaje

Reforzar los fundamentos de C# y aplicar conceptos de programación orientada a objetos en un escenario inspirado en la automatización y el mantenimiento industrial.

## Posibles mejoras

- Incorporar un historial de mantenimientos realizados.
- Registrar la fecha del último mantenimiento.
- Generar alertas cuando una máquina se aproxime al límite de mantenimiento.
- Mejorar la validación y el formato de los datos almacenados.
- Generar reportes de producción y disponibilidad.
- Incorporar pruebas unitarias.
- En una etapa posterior, integrar una base de datos y una interfaz gráfica.

## Estado del proyecto

Proyecto educativo en desarrollo. La revisión y validación final del sistema completo requiere integrar y probar todos los archivos fuente.

## Autor

Desarrollado como parte de un proceso de aprendizaje y práctica de programación en C#.
