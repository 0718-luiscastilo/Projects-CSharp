using System;
    public class RobotTransporte : RobotIndustrial{
        private double capacidadCarga;
        private double velocidadTransporte;
        private double distanciaRecorrida;

        public double CapacidadCarga{
            get{
                return capacidadCarga;
            }
            set{
                if (double.IsNaN(value) || double.IsInfinity(value) || value <= 0){
                    throw new ArgumentException("La capacidad de carga no pude ser negavita");
                }
                capacidadCarga = value;
            }
        }
        public double VelocidadTrasporte{
            get{
                return velocidadTransporte;
            }
            set{
                if (double.IsNaN(value) || double.IsInfinity(value) || value <= 0){
                    throw new ArgumentException("La velocidad de trasporte no pude ser negavita");
                }
                velocidadTransporte = value;
            }
        }
        public double DistanciaRecorrida{
            get{
                return distanciaRecorrida;
            }
            set{
                if (double.IsNaN(value) || double.IsInfinity(value) || value <= 0){
                    throw new ArgumentException("La distancia recorida no pude ser negavita");
                }
                distanciaRecorrida = value;
            }
        }
        public RobotTransporte(int id, string nombre, string modelo, string fabricante, int anioFabricacion, 
        double horasFuncionamiento, double temperaturaMotor, string estado, int cantidadFallos, double capacidadCarga,
        double velocidadTransporte, double distanciaRecorrida) : base(id, nombre, modelo, fabricante, anioFabricacion, horasFuncionamiento, 
        temperaturaMotor, estado, cantidadFallos){
            CapacidadCarga = capacidadCarga;
            VelocidadTrasporte =velocidadTransporte;
            DistanciaRecorrida = distanciaRecorrida;
            
        }
        public override void MostrarInformacion(){
        base.MostrarInformacion();
        Console.WriteLine($"Capacidad de Carga: {capacidadCarga}");
        Console.WriteLine($"Velocidad de Trasporte: {velocidadTransporte}");
        Console.WriteLine($"Distancia Recorida: {distanciaRecorrida}");
        }

        public override void EjecutarTarea(){
            Console.WriteLine($"El robot {Nombre} está trasportando cosas.");
        }
        public void CalcularDistanciaRecorrida(double nuevaDistancia){
            DistanciaRecorrida = nuevaDistancia;
            Console.WriteLine($"El robot con {Nombre} tiene una distancia de {nuevaDistancia} km/h");
        }

    }
