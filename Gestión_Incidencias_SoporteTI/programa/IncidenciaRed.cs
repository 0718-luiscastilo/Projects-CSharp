using System;
public class IncidenciaHardware : Incidencia, IProcesable{
    private string recursoAfectado:
    public string RecursoAfectado { 
        get {
            return recursoAfectado;
        } 
        set {
            if(string.IsNullOrEmpty(value)){
                throw new Exception("El nombre del recurso afectado no puede estar vacío");
            recursoAfectado = value;
            }
        }
    }
    public IncidenciaHardware(string identificador, string nombreIncidencia, string nombreEmpleado, string descripcion, string prioridad, string estado, string recursoAfectado) 
    : base(identificador, nombreIncidencia, nombreEmpleado, descripcion, prioridad, estado){
        this.recursoAfectado = recursoAfectado;
    }
    public IncidenciaHardware() : base(){
        this.recursoAfectado = "";
    }
    public virtual void mostrarInformacion(){
        Console.WriteLine("Identificador: " + Identificador);
        Console.WriteLine("Nombre de la incidencia: " + NombreIncidencia);
        Console.WriteLine("Nombre del empleado: " + NombreEmpleado);
        Console.WriteLine("Descripción: " + Descripcion);
        Console.WriteLine("Prioridad: " + Prioridad);
        Console.WriteLine("Estado: " + Estado);
        Console.WriteLine("Recurso afectado: " + RecursoAfectado);
    }
    public void procesarIncidencia(){
        Console.WriteLine("Diagnosticando " + NombreIncidencia + " del empleado " + NombreEmpleado + " en el recurso " + RecursoAfectado);
    }
    
}