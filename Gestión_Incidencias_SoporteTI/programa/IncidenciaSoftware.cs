using System;
public class IncidenciaSoftware : Incidencia, IProcesable{
    private string aplicacionAfectada;
    public string AplicacionAfectada { 
        get {
            return aplicacionAfectada;
        } 
        set {
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
        Console.WriteLine("Identificador: " + Identificador);
        Console.WriteLine("Nombre de la incidencia: " + NombreIncidencia);
        Console.WriteLine("Nombre del empleado: " + NombreEmpleado);
        Console.WriteLine("Descripción: " + Descripcion);
        Console.WriteLine("Prioridad: " + Prioridad);
        Console.WriteLine("Estado: " + Estado);
        Console.WriteLine("Aplicación afectada: " + AplicacionAfectada);
    }
    public void ProcesarIncidencia(){
        Console.WriteLine("Diagnosticando " + NombreIncidencia + " del empleado " + NombreEmpleado + " en la aplicación " + AplicacionAfectada);
    }
     
}