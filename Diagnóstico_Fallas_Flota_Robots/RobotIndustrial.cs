using System;
    public abstract class RobotIndustrial{
        private int id;
        private string nombre;
        private string modelo;
        private string fabricante;
        private int anioFabricacion;
        private double horasFuncionamiento;
        private double temperaturaMotor;
        private string estado;
        private int cantidadFallos;
        public int Id{
            get { 
                return id; 
            }
            set {
                if(value <= 0){
                    throw new ArgumentException("El ID no puede ser negativo.");
                }
                id = value; 
            }
        }
        public string Nombre{
            get { 
                return nombre; 
            }
            set {
                if(string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentException("El nombre no puede estar vacío.");
                }
                nombre = value; 
            }
        }
        public string Modelo{
            get { 
                return modelo; 
            }
            set {
                if(string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentException("El modelo no puede estar vacío.");
                }
                modelo = value; 
            }
        }
        public string Fabricante{
            get { 
                return fabricante; 
            }
            set {
                if(string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentException("El fabricante no puede estar vacío.");
                }
                fabricante = value; 
            }
        }
        public int AnioFabricacion{
            get { 
                return anioFabricacion; 
            }
            set {
                if(value < 1900 || value > DateTime.Now.Year){
                    throw new ArgumentException("El año de fabricación no es válido.");
                }
                anioFabricacion = value; 
            }
        }
        public double HorasFuncionamiento{
            get { 
                return horasFuncionamiento; 
            }
            set {
                if(value < 0){
                    throw new ArgumentException("Las horas de funcionamiento no pueden ser negativas.");
                }
                horasFuncionamiento = value; 
            }
        }
        public double TemperaturaMotor{
            get { 
                return temperaturaMotor; 
            }
            set {
                if(value <= 0){
                    throw new ArgumentException("La temperatura del motor no puede ser negativa.");
                }
                temperaturaMotor = value; 
            }
        }
        public string Estado{
            get { 
                return estado; 
            }
            set {
                if(string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentException("El estado no puede estar vacío.");
                }
                estado = value; 
            }
        }
        public int CantidadFallos{
            get { 
                return cantidadFallos; 
            }
            set {
                if(value < 0){
                    throw new ArgumentException("La cantidad de fallos no puede ser negativa.");
                }
                cantidadFallos = value; 
            }
        }
        public RobotIndustrial(int id, string nombre, string modelo, string fabricante, int anioFabricacion, double horasFuncionamiento, double temperaturaMotor, string estado, int cantidadFallos){
            Id = id;
            Nombre = nombre;
            Modelo = modelo;
            Fabricante = fabricante;
            AnioFabricacion = anioFabricacion;
            HorasFuncionamiento = horasFuncionamiento;
            TemperaturaMotor = temperaturaMotor;
            Estado = estado;
            CantidadFallos = cantidadFallos;
        }
        public virtual void mostrarInformacion(){
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Modelo: {modelo}");
            Console.WriteLine($"Fabricante: {fabricante}");
            Console.WriteLine($"Año de Fabricación: {anioFabricacion}");
            Console.WriteLine($"Horas de Funcionamiento: {horasFuncionamiento}");
            Console.WriteLine($"Temperatura del Motor: {temperaturaMotor}");
            Console.WriteLine($"Estado: {estado}");
            Console.WriteLine($"Cantidad de Fallos: {cantidadFallos}");
        }
    
    }
