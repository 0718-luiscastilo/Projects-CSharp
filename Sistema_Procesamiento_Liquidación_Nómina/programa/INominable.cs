using System;

public interface INominable{
    // Propiedad de solo lectura para obtener el detalle formato string
    string DetalleEmpleado { get; }
    // Método para calcular el sueldo neto
    int CalcularSueldoNeto();
}
    