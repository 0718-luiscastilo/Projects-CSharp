using System;
    public class BandaTransportadora
    {
        private double velocidadBanda;
        private double longitudBanda;
        private doble capacidadCarga;

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
            }
        }
        public BandaTransportadora(int id, string nombre, string modelo,
        int tempMaquina, int horasFuncionamiento, int cantidadPiezas, string estado
        , double velocidadBanda, double longitudBanda, double capacidadCarga) : base (id, nombre, modelo,
        tempMaquina, horasFuncionamiento, cantidadPiezas, estado)
        {
            this.velocidadBanda = velocidadBanda;
            this.longitudBanda = longitudBanda;
            this.capacidadCarga = capacidadCarga;
        }
        public override void mostrarInformacion()
        {
            base.mostrarInformacion();
            Console.WriteLine("Velocidad de la Banda: " + velocidadBanda + " m/s");
            Console.WriteLine("Longitud de la Banda: " + longitudBanda + " m");
            Console.WriteLine("Capacidad de Carga: " + capacidadCarga + " kg");
        }
    }
