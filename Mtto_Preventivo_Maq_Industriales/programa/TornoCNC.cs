using System;
public class TornoCNC : MaquinaIndustrial
{
    private int velocidadHusillo;
    private double diametroMaximo;
    private string tipoHerramienta;

    public int VelocidadHusillo
    {
        get
        {
            return velocidadHusillo;
        }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException ("La velocidad no puede ser negativa.");
            }
            velocidadHusillo = value;
        }
    }
    public double DiametroMaximo
    {
        get
        {
            return diametroMaximo;
        }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException ("El Diametro no puede ser menor que cero.");
            }
            diametroMaximo = value;
        }
    }
     public string TipoHerramienta
    {
        get
        {
            return tipoHerramienta;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new AggregateException("El tipo de hermanienta no puede estar vacio");
            }
            tipoHerramienta = value;
        }
    }
    public TornoCNC(int id, string nombre, string modelo, 
    int tempMaquina, int horasFuncionamiento, int cantidadPiezas, string estado, int velocidadHusillo, 
    double diametroMaximo, string tipoHerramienta) : base (id, nombre, modelo,
    tempMaquina, horasFuncionamiento, cantidadPiezas, estado)
    {
        this.velocidadHusillo = velocidadHusillo;
        this.diametroMaximo = diametroMaximo;
        this.tipoHerramienta = tipoHerramienta;
    }
    public override void mostrarInformacion()
    {
        base.mostrarInformacion();
        Console.WriteLine("Velocidad de Huesillo: " + velocidadHusillo);
        Console.WriteLine("Diametro del Maximo: " + diametroMaximo);
        Console.WriteLine("Tipo de Herramienta: " + tipoHerramienta);
    }
    public void RealizarCilindrado(int diametro)
    {
        Console.WriteLine("Se esta reduciondo el diametro de la pieza a " + diametro);
    }
    public void RealizarRefrentado()
    {
        Console.WriteLine("Se esta ranurando la pieza");
    }
    

    
}
