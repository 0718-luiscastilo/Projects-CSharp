using System;
public class Incidencia{
    private string identificador;
    private string nombreIncidencia;
    private string nombreEmpleado;
    private string descripcion;
    private string prioridad;
    private string estado;
    
    public string Identificador { 
        get {
            return identificador;
        } 
        set {
            identificador = value;
            
        }
    }
    public string NombreIncidencia { 
        get {
            return nombreIncidencia;
        } 
        set {
            nombreIncidencia = value;

        }
    }
    public string NombreEmpleado { 
        get {
            return nombreEmpleado;
        } 
        set {
        
            nombreEmpleado = value;    
        }
    }
    public string Descripcion { 
        get {
            return descripcion;
        } 
        set {
            descripcion = value;
        }
    }
    public string Prioridad { 
        get {
            return prioridad;
        } 
        set {
            prioridad = value;
        }
    
    }
    public string Estado { 
        get {
            return estado;
        } 
        set {
            estado = value;
        }
    }
    public Incidencia(string identificador, string nombreIncidencia, string nombreEmpleado, string descripcion, string prioridad, string estado){
        this.identificador = identificador;
        this.nombreIncidencia = nombreIncidencia;
        this.nombreEmpleado = nombreEmpleado;
        this.descripcion = descripcion;
        this.prioridad = prioridad;
        this.estado = estado;
    }
    public Incidencia(){
        this.identificador = "INC-001";
        this.nombreIncidencia = "Incidencia de prueba";
        this.nombreEmpleado = "Sin Asignar";
        this.descripcion = "Descripcion pendiente";
        this.prioridad = "Baja";
        this.estado = "Abierta";
    }
    public virtual void mostrarInformacion(){
        Console.WriteLine("Identificador: " + identificador);
        Console.WriteLine("Nombre de la Incidencia: " + nombreIncidencia);
        Console.WriteLine("Nombre del Empleado: " + nombreEmpleado);
        Console.WriteLine("Descripcion: " + descripcion);
        Console.WriteLine("Prioridad: " + prioridad);
        Console.WriteLine("Estado: " + estado);
    }

}