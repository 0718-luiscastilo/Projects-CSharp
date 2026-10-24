using System;
public class IncidenciaRed : Incidencia, IProcesable{
    private string recursoAfectado;
    public string RecursoAfectado { 
        get {
            return recursoAfectado;
        } 
        set {
            if (string.IsNullOrWhiteSpace(value)){
                throw new ArgumentException("El equipo afectado no puede estar vacío.");
            }
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
        base.mostrarInformacion();
        Console.WriteLine("Recurso afectado: " + RecursoAfectado);
    }
    public void ProcesarIncidencia(){
        Console.WriteLine("Diagnosticando " + NombreIncidencia + " del empleado " + NombreEmpleado + " en el recurso " + RecursoAfectado);
    }
    
}