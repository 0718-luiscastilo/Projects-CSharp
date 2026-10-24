using System;
public class IncidenciaSoftware : Incidencia, IProcesable{
    private string aplicacionAfectada;
    public string AplicacionAfectada { 
        get {
            return aplicacionAfectada;
        } 
        set {
            if (string.IsNullOrWhiteSpace(value)){
                throw new ArgumentException("El equipo afectado no puede estar vacío.");
            }
            aplicacionAfectada = value;
        }
    }
    public IncidenciaSoftware(string identificador, string nombreIncidencia, string nombreEmpleado, string descripcion, string prioridad, 
    string estado, string aplicacionAfectada) : base(identificador, nombreIncidencia, nombreEmpleado, descripcion, prioridad, estado){
        this.aplicacionAfectada = aplicacionAfectada;
    }
    public IncidenciaSoftware() : base(){
        this.aplicacionAfectada = "";
    }
    public virtual void mostrarInformacion(){
        base.mostrarInformacion();
        Console.WriteLine("Aplicación afectada: " + AplicacionAfectada);
    }
    public void ProcesarIncidencia(){
        Console.WriteLine("Diagnosticando " + NombreIncidencia + " del empleado " + NombreEmpleado + " en la aplicación " + AplicacionAfectada);
    }
     
}