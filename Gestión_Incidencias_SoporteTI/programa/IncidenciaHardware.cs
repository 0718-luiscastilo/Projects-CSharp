using System;
public class IncidenciaHardware : Incidencia, IProcesable{
    private string equipoAfectado;
    public string EquipoAfectado { 
        get {
            return equipoAfectado;
        } 
        set {
            if (string.IsNullOrWhiteSpace(value)){
                throw new ArgumentException("El equipo afectado no puede estar vacío.");
            }
            equipoAfectado = value;
        }
    }
    public IncidenciaHardware(string identificador, string nombreIncidencia, string nombreEmpleado, string descripcion, string prioridad, 
    string estado, string equipoAfectado) : base(identificador, nombreIncidencia, nombreEmpleado, descripcion, prioridad, estado){
        this.equipoAfectado = equipoAfectado;
    }
    public virtual void mostrarInformacion(){
        base.mostrarInformacion();
        Console.WriteLine("Equipo afectado: " + EquipoAfectado);
    }
    public void ProcesarIncidencia(){
        Console.WriteLine("Diagnosticando " + NombreIncidencia + " del empleado " + NombreEmpleado + " en el equipo " + EquipoAfectado);
    }

}