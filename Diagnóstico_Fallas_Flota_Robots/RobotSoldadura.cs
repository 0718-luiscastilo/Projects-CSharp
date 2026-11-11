using System;

public class RobotSoldadura: RobotIndustrial{
        private double temperaturaSoldadura;
        private string tipoSoldadura;
        private int cantidadSoldaduras;
        public double TemperaturaSoldadura{
            get{
                return temperaturaSoldadura;
            }
            set{
                if (double.IsNaN(value) || double.IsInfinity(value) || value <= 0){
                    throw new ArgumentException("La Temperatura no puede ser negativa");
                }
                temperaturaSoldadura = value;
            } 
        }
        public string TipoSoldadura{
            get{
                return tipoSoldadura;
            }
            set{
                if (string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentException("El tipo de soldadura no puede estar vacia");
                }
            tipoSoldadura = value.Trim();
            }
        }
        public int CantidadSoldaduras{
            get{
                return cantidadSoldaduras;
            }
            set{
                if (value < 0){
                    throw new ArgumentException("La cantidad de Soldadura no puede ser negavita");
                }
                cantidadSoldaduras = value;
            }
        }
        public RobotSoldadura(int id, string nombre, string modelo, string fabricante, int anioFabricacion, 
        double horasFuncionamiento, double temperaturaMotor, string estado, int cantidadFallos, double temperaturaSoldadura,
        string tipoSoldadura, int cantidadSoldaduras) : base (id, nombre, modelo, fabricante, anioFabricacion, horasFuncionamiento, 
        temperaturaMotor, estado, cantidadFallos){
            TemperaturaSoldadura = temperaturaSoldadura;
            TipoSoldadura = tipoSoldadura;
            CantidadSoldaduras = cantidadSoldaduras;
        }
        public override void MostrarInformacion(){
            base.MostrarInformacion();
            Console.WriteLine($"Temperatura de Soldadura : {temperaturaSoldadura}");
            Console.WriteLine($"Tipo de Soldadura: {tipoSoldadura}");
            Console.WriteLine($"Cantidad de Soldadura: {cantidadSoldaduras}");
        }
        public override void EjecutarTarea(){
            Console.WriteLine($"El robot {Nombre} está ensamblando piezas.");
        }
        public void CambiarTipoSoldadura(string nuevaSoldadura){
            TipoSoldadura = nuevaSoldadura;
            Console.WriteLine($"El robot {Nombre} cambio su soldadura a {nuevaSoldadura}.");
        }

    }
