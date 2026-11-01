using System;
using System.Linq.Expressions;
public class Fresadora : MaquinaIndustrial
    {
        private double velocidadCorte;
        private int numeroEjes;
        private string tipoFresa;
    public double VelocidadCorte{
        get
        {
            return velocidadCorte;
        }
        set
        {
            if(value < 0)
            {
                throw new AggregateException ("La velocidad de corte no puede ser negaviva");
            }
        }
    }
    public int NumeroEjes
    {
        get
        {
            return numeroEjes;
        }
        set
        {
            if (value < 0)
            {
                throw new AggregateException("El numero de Ejes no puede ser negativo");
            }
        }
    }
    public string TipoFresa
    {
        get
        {
            return tipoFresa;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new AggregateException("El tipo de Fresa no puede esta vacia");
            }
        }
    }
    public Fresadora(int id, string nombre, string modelo, 
    int tempMaquina, int horasFuncionamiento, int cantidadPiezas, string estado, double velocidadCorte,
    int numeroEjes, string tipoFresa) : base (id, nombre, modelo,
    tempMaquina, horasFuncionamiento, cantidadPiezas, estado)
    {
        this.velocidadCorte = velocidadCorte;
        this.numeroEjes = numeroEjes;
        this.tipoFresa = tipoFresa;
    }
    public override void mostrarInformacion()
    {
        base.mostrarInformacion();
        Console.WriteLine("Velocidad de Corte: " + velocidadCorte);
        Console.WriteLine("Numero de Ejes: " + numeroEjes);
        Console.WriteLine("Tipo de Fresa: " + tipoFresa);
    }
    public void RealizarRanurado()
    {
        Console.WriteLine("La Maquina" + Nombre + "esta haciendo el Ranurado a la pieza ");
    }
    public void RealizarPlaneado()
    {
        Console.WriteLine("La Maquina" + Nombre + " esta haciendo mecanizado para obtener una superficie plana.");
    }



        
}
