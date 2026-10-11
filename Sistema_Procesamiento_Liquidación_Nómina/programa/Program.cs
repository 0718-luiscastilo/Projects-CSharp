﻿using System;
public class Program{
    public static void Main(string[] args){
         Console.WriteLine(" Bienvenido al Sistema de Procesamiento de Liquidación de Nómina");
         Console.WriteLine("---------------------------------------------------------------");
         Console.WriteLine("Ingrese cantidad de empleados a procesar:");
         int cantidadEmpleados = int.Parse(Console.ReadLine());
         while(cantidadEmpleados <= 0){
            Console.WriteLine("La cantidad de empleados debe ser mayor a cero. Intente nuevamente:");
            cantidadEmpleados = int.Parse(Console.ReadLine());
         }
         Empleado[] empleados = new Empleado[cantidadEmpleados];
         for(int i = 0; i < cantidadEmpleados; i++){
            Console.WriteLine($"Ingrese el tipo de empleado para el empleado {i + 1} (1: Contratista, 2: Empleado a Tiempo Completo, 3: Ejecutivo):");
            int tipoEmpleado = int.Parse(Console.ReadLine());
            while(tipoEmpleado < 1 || tipoEmpleado > 3){
                Console.WriteLine("Tipo de empleado inválido. Intente nuevamente:");
                tipoEmpleado = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ingrese ID del empleado:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nombre del empleado:");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese sueldo base del empleado:");
            int sueldoBase = int.Parse(Console.ReadLine());
            switch(tipoEmpleado){
                case 1:
                    Console.WriteLine("Ingrese horas trabajadas del contratista:");
                    int horasTrabajadas = int.Parse(Console.ReadLine());
                    empleados[i] = new Contratista(id, nombre, sueldoBase, horasTrabajadas);
                    break;
                case 2:
                    Console.WriteLine("Ingrese bono del empleado a tiempo completo:");
                    int bono = int.Parse(Console.ReadLine());
                    empleados[i] = new EmpleadoTiempoCompleto(id, nombre, sueldoBase, bono);
                    break;
                case 3:
                    Console.WriteLine("Ingrese bono del ejecutivo:");
                    int bonoEjecutivo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese bono de gestión del ejecutivo:");
                    int bonoGestion = int.Parse(Console.ReadLine());
                    empleados[i] = new Ejecutivo(id, nombre, sueldoBase, bonoEjecutivo, bonoGestion);
                    break;
            }
         }
    }


}