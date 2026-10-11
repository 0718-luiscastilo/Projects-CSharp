using System;
public class Contratista : Empleado{
    private int horasTrabajadas;
    public int HorasTrabajadas{ 
        get{
            return horasTrabajadas;
        }
        set{
            if(value >= 0){
                horasTrabajadas = value;
            }else{
                throw new ArgumentException("Las horas trabajadas no pueden ser negativas.");
            }
        }
    }
    public Contratista(int id, string nombre, int sueldoBase, int horasTrabajadas) : base(id, nombre, sueldoBase){
        this.HorasTrabajadas = horasTrabajadas;
    }
    public Contratista() : base(){
        HorasTrabajadas = 0;
    }
    public override string DetalleEmpleado{
        get{
            return $"ID: {Id}, Nombre: {Nombre}, Sueldo Base: {SueldoBase:C}, Horas Trabajadas: {HorasTrabajadas}";
        }
    }
    public override int CalcularSueldoNeto(){
        return SueldoBase * HorasTrabajadas;
    }
}
    