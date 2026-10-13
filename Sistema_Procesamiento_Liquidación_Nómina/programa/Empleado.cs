using System;
public abstract class Empleado : INominable{
    private int id;
    private string nombre;
    private int sueldoBase;

    public int Id{ 
        get{
            return id;
        }
        set{
            if(value >= 0){
                id = value;
            }else{
                throw new ArgumentException("El ID del empleado no puede ser negativo.");
            }
        }
    }
    public string Nombre{ 
        get{
            return nombre;
        }
        set{
            if(!string.IsNullOrWhiteSpace(value)){
                nombre = value;
            }else{
                throw new ArgumentException("El nombre del empleado no puede estar vacío.");
            }
        }
    }
    public int SueldoBase{ 
        get{
            return sueldoBase;
        }
        set{
            if(value >= 0){
                sueldoBase = value;
            }else{
                throw new ArgumentException("El sueldo base del empleado no puede ser negativo.");
            }
        }
    }
    public Empleado(int id, string nombre, int sueldoBase){
        this.Id = id;
        this.Nombre = nombre;
        this.SueldoBase = sueldoBase;
    }
    public Empleado(){
        Id = 0;
        Nombre = "Empleado";
        SueldoBase = 0;
    }
    public virtual string DetalleEmpleado{
        get{
            return $"ID: {Id}, Nombre: {Nombre}, Sueldo Base: {SueldoBase:C}";
        }
    }
    ~Empleado(){
        Console.WriteLine($"[Liberando memoria]: Objeto Empleado con ID {id} destruido.");
    }
    public abstract int CalcularSueldoNeto();


}