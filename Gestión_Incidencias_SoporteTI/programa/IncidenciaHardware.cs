using System;
public class IncidenciaHardware : Incidencia, IProcesable{
    private string equipoAfectado;
    public string EquipoAfectado { 
        get {
            return equipoAfectado;
        } 
        set {
            equipoAfectado = value;
    
        }
    }
    public IncidenciaHardware(string identificador, string nombreIncidencia, string nombreEmpleado, string descripcion, string prioridad, 
    string estado, string equipoAfectado) : base(identificador, nombreIncidencia, nombreEmpleado, descripcion, prioridad, estado){
        this.equipoAfectado = equipoAfectado;
    }
    public virtual void mostrarInformacion(){
        Console.WriteLine("Identificador: " + Identificador);
        Console.WriteLine("Nombre de la incidencia: " + NombreIncidencia);
        Console.WriteLine("Nombre del empleado: " + NombreEmpleado);
        Console.WriteLine("Descripción: " + Descripcion);
        Console.WriteLine("Prioridad: " + Prioridad);
        Console.WriteLine("Estado: " + Estado);
        Console.WriteLine("Equipo afectado: " + EquipoAfectado);
    }
    public void ProcesarIncidencia(){
        Console.WriteLine("Diagnosticando " + NombreIncidencia + " del empleado " + NombreEmpleado + " en el equipo " + EquipoAfectado);
    }

}