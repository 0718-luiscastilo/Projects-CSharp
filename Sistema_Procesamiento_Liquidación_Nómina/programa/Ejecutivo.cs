using System;
public class Ejecutivo : EmpleadoTiempoCompleto{
    private int Bono_Gestion;
    public int BonoGestion{ 
        get{
            return BonoGestion;
        }
        set{
            if(value >= 0){
                BonoGestion = value;
            }else{
                throw new ArgumentException("El bono de gestión del ejecutivo no puede ser negativo.");
            }
        }
    }
    public Ejecutivo(int id, string nombre, int sueldoBase, int bono, int bonoGestion) : base(id, nombre, sueldoBase, bono){
        this.BonoGestion = bonoGestion;
    }
    public Ejecutivo() : base(){
        BonoGestion = 0;
    }
    public override string DetalleEmpleado{
        get{
            return $"ID: {Id}, Nombre: {Nombre}, Sueldo Base: {SueldoBase:C}, Bono: {Bono:C}, Bono de Gestión: {BonoGestion:C}";
        }
    }
    public override int CalcularSueldoNeto(){
        return SueldoBase + Bono + BonoGestion;
    }

}