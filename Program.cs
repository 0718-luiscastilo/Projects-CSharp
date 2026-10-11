﻿using System;
public class Program{
    public static void Main(string[] args){
        Console.WriteLine("=== Bienvenido al Sistema de Procesamiento de Liquidación de Nómina ===");
        Console.WriteLine("---------------------------------------------------------------------");
        
        Console.WriteLine("Ingrese cantidad de empleados a procesar:");
        int cantidadEmpleados = 0;
        
        // Validación segura de la cantidad
        while (!int.TryParse(Console.ReadLine(), out cantidadEmpleados) || cantidadEmpleados <= 0){
            Console.WriteLine("Valor inválido. La cantidad de empleados debe ser mayor a cero. Intente nuevamente:");
        }
        Empleado[] empleados = new Empleado[cantidadEmpleados];
        for (int i = 0; i < cantidadEmpleados; i++){
            Console.WriteLine($"\n--- Registro del empleado {i + 1} de {cantidadEmpleados} ---");
            Console.WriteLine("Ingrese el tipo de empleado (1: Contratista, 2: Empleado a Tiempo Completo, 3: Ejecutivo):");
            int tipoEmpleado = 0;
            while (!int.TryParse(Console.ReadLine(), out tipoEmpleado) || tipoEmpleado < 1 || tipoEmpleado > 3){
                Console.WriteLine("Tipo de empleado inválido. Intente nuevamente (1, 2 o 3):");
            }
            Console.WriteLine("Ingrese ID del empleado:");
            int id = int.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Ingrese nombre del empleado:");
            string nombre = Console.ReadLine() ?? "Sin Nombre";

            Console.WriteLine("Ingrese sueldo base del empleado:");
            int sueldoBase = int.Parse(Console.ReadLine() ?? "0");
            switch (tipoEmpleado){
                case 1:
                    Console.WriteLine("Ingrese horas trabajadas del contratista:");
                    int horasTrabajadas = int.Parse(Console.ReadLine() ?? "0");
                    empleados[i] = new Contratista(id, nombre, sueldoBase, horasTrabajadas);
                    break;

                case 2:
                    Console.WriteLine("Ingrese bono del empleado a tiempo completo:");
                    int bono = int.Parse(Console.ReadLine() ?? "0");
                    empleados[i] = new EmpleadoTiempoCompleto(id, nombre, sueldoBase, bono);
                    break;
                case 3:
                    Console.WriteLine("Ingrese bono base del ejecutivo (equivalente a bono tiempo completo):");
                    int bonoEjecutivo = int.Parse(Console.ReadLine() ?? "0");
                    Console.WriteLine("Ingrese bono de gestión del ejecutivo:");
                    int bonoGestion = int.Parse(Console.ReadLine() ?? "0");
                    empleados[i] = new Ejecutivo(id, nombre, sueldoBase, bonoEjecutivo, bonoGestion);
                    break;
            }
        }
        // REPORTE CONSOLIDADO DE NÓMINA (Polimorfismo e Iteración)
        Console.WriteLine("\n==================================================");
        Console.WriteLine("         REPORTE CONSOLIDADO DE NÓMINA            ");
        Console.WriteLine("==================================================");
        int totalNomina = 0;
        for (int i = 0; i < empleados.Length; i++){
            if (empleados[i] != null){
                // Uso polimórfico de DetalleEmpleado y CalcularSueldoNeto()
                Console.WriteLine($"{empleados[i].DetalleEmpleado} | Sueldo Neto: {empleados[i].CalcularSueldoNeto():C}");
                totalNomina += empleados[i].CalcularSueldoNeto();
            }
        }
        Console.WriteLine("--------------------------------------------------");
        Console.WriteLine($"Total a pagar en nómina: {totalNomina:C}");
        Console.WriteLine("Procesamiento completado con éxito.");
    }
}