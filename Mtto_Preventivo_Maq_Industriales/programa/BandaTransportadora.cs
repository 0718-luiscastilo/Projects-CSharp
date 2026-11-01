using System;
    public class BandaTransportadora : MaquinaIndustrial
    {
        private double velocidadBanda;
        private double longitudBanda;
        private double capacidadCarga;

        public double VelocidadBanda
        {
            get
            {
                return velocidadBanda;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException ("La velocidad de la banda no puede ser negativa.");
                }
                velocidadBanda = value;
            }
        }
        public double LongitudBanda
        {
            get
            {
                return longitudBanda;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException ("La longitud de la banda no puede ser negativa.");
                }
                longitudBanda = value;
            }
        }
        public double CapacidadCarga
        {
            get
            {
                return capacidadCarga;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException ("La capacidad de carga no puede ser negativa.");
                }
                capacidadCarga = value;
            }
        }
        public BandaTransportadora(int id, string nombre, string modelo,
        int tempMaquina, int horasFuncionamiento, int cantidadPiezas, string estado, 
        double velocidadBanda, double longitudBanda, double capacidadCarga) : base (id, nombre, modelo,
        tempMaquina, horasFuncionamiento, cantidadPiezas, estado)
        {
            VelocidadBanda = velocidadBanda;
            LongitudBanda = longitudBanda;
            CapacidadCarga = capacidadCarga;
        }
        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine("Velocidad de la Banda: " + velocidadBanda + " m/s");
            Console.WriteLine("Longitud de la Banda: " + longitudBanda + " m");
            Console.WriteLine("Capacidad de Carga: " + capacidadCarga + " kg");
        }
        public void IniciarTransporte()
        {
        Console.WriteLine("La Maquina " + Nombre + " esta transportando la pieza");
        }
        public void DetenerTransporte()
        {
        Console.WriteLine("La Maquina " + Nombre + " ha detenido el transporte de la pieza");
        }
    }
