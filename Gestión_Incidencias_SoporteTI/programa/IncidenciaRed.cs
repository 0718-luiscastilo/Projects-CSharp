using System;
public class IncidenciaRed : Incidencia, IProcesable{
    private string recursoAfectado;
    public string RecursoAfectado { 
        get {
            return recursoAfectado;
        } 
        set {
            recursoAfectado = value;
            }
    }
    public IncidenciaRed(string identificador, string nombreIncidencia, string nombreEmpleado, string descripcion, string prioridad, string estado, string recursoAfectado) 
    : base(identificador, nombreIncidencia, nombreEmpleado, descripcion, prioridad, estado){
        this.recursoAfectado = recursoAfectado;
    }
    public IncidenciaRed() : base(){
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
    public void ProcesarIncidencia(){
        Console.WriteLine("Diagnosticando " + NombreIncidencia + " del empleado " + NombreEmpleado + " en el recurso " + RecursoAfectado);
    }
    
}