# 💼 Sistema de Procesamiento y Liquidación de Nómina en C#

Aplicación de consola desarrollada en **C#** enfocada en la aplicación práctica de los principios de **Programación Orientada a Objetos (POO)**. El sistema permite registrar dinámicamente empleados bajo diferentes regímenes de contratación, calcular sus retribuciones netas de forma polimórfica y emitir un reporte consolidado de costos salariales.

---

## 🚀 Características y Conceptos Aplicados
* **Interfaces:** Contrato base (`INominable`) para estandarizar el comportamiento de los empleados.
* **Clases Abstractas y Herencia:** Jerarquía desde una clase base `Empleado` hacia clases derivadas (`Contratista`, `EmpleadoTiempoCompleto`, `Ejecutivo`).
* **Polimorfismo:** Métodos virtuales y sobreescritura (`override`) para el cálculo de sueldos adaptados a cada tipo de empleado.
* **Encapsulamiento:** Propiedades seguras con validaciones estrictas en los bloques `set` para evitar datos negativos o vacíos.
* **Constructores y `this`:** Sobrecarga de constructores y encadenamiento seguro.
* **Gestión de Recursos:** Uso de destructores (`~Empleado()`) para control de ciclo de vida en memoria.
* **Control de Flujo:** Validación robusta de entradas mediante bucles `while`/`for` y bifurcaciones `switch`.

---

## 🛠️ Tecnologías Requeridas
* [.NET SDK](https://dotnet.microsoft.com/) (versión 6.0 o superior recomendada).
* Cualquier entorno de desarrollo compatible (Visual Studio, Visual Studio Code o la CLI de .NET).

---

## 📥 Instrucciones de Descarga y Ejecución

1. **Clona el repositorio** en tu máquina local:
   ```bash
   git clone [https://github.com/tu-usuario/tu-repositorio.git](https://github.com/tu-usuario/tu-repositorio.git)