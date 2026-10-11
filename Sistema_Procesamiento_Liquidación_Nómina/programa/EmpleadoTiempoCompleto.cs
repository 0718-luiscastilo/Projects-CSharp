using System;
public class EmpleadoTiempoCompleto : Empleado{
    private int bono;
    
    public int Bono{ 
        get{
            return bono;
        }
        set{
            if(value >= 0){
                bono = value;
            }else{
                throw new ArgumentException("El bono del empleado no puede ser negativo.");
            }
        }
    }
    public EmpleadoTiempoCompleto(int id, string nombre, int sueldoBase, int bono) : base(id, nombre, sueldoBase){
        this.Bono = bono;
    }
    public EmpleadoTiempoCompleto() : base(){
        Bono = 0;
    }
    public override string DetalleEmpleado{
        get{
            return $"ID: {Id}, Nombre: {Nombre}, Sueldo Base: {SueldoBase:C}, Bono: {Bono:C}";
        }
    }
    public override int CalcularSueldoNeto(){
        return SueldoBase + Bono;
    }
}