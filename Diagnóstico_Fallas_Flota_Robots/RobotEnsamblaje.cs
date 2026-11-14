using System;

    public class RobotEnsamblaje : RobotIndustrial{
        private int cantidadPiezasEnsambladas;
        private double precisionMilimetrica;
        private string tipoHerramienta = string.Empty;
        public int CantidadPiezasEnsambladas{
            get{
            return cantidadPiezasEnsambladas; 
            }
            set{
                if(value < 0){
                        throw new ArgumentException("La cantidad de Piezas ensambladas no puede ser negativa");
                    } 
                cantidadPiezasEnsambladas = value;
            }
        }
        public double PrecisionMilimetrica{
            get{
                return precisionMilimetrica;
            }
            set{
                if (double.IsNaN(value) || double.IsInfinity(value) || value <= 0){
                    throw new ArgumentException("La precisión milimétrica debe ser mayor que cero.");
                }
            precisionMilimetrica = value;
            }
        }
        public string TipoHerramienta{
            get{
                return tipoHerramienta;
            }
            set{
                if (string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentException ("El tipo de herramienta no puede estar vacio");
                }
                tipoHerramienta = value.Trim();    
            }
        }
        public RobotEnsamblaje(int id, string nombre, string modelo, string fabricante, int anioFabricacion, 
        double horasFuncionamiento, double temperaturaMotor, string estado, int cantidadFallos, int cantidadPiezasEnsambladas,
        double precisionMilimetrica, string tipoHerramienta) : base (id, nombre, modelo, fabricante, anioFabricacion, horasFuncionamiento, 
        temperaturaMotor, estado, cantidadFallos){
            CantidadPiezasEnsambladas = cantidadPiezasEnsambladas;
            PrecisionMilimetrica = precisionMilimetrica;
            TipoHerramienta = tipoHerramienta;
        
        }
    public override void MostrarInformacion(){
        base.MostrarInformacion();
        Console.WriteLine($"Cantidad de Piezas Ensambladas : {cantidadPiezasEnsambladas}");
        Console.WriteLine($"Presicion milimetrica: {precisionMilimetrica}");
        Console.WriteLine($"Tipo de Herramienta: {tipoHerramienta}");
    }
    public override void EjecutarTarea(){
            Console.WriteLine($"El robot {Nombre} está ensamblando piezas.");
        }
    public void CambiarHerramienta(string herramientaNueva){
        TipoHerramienta = herramientaNueva;
        Console.WriteLine($"El robot {Nombre} está cambiando a {TipoHerramienta}.");
    }
}
