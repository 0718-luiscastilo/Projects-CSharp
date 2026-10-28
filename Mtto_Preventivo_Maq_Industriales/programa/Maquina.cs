using System;
public class Maquina{
    private int id;
    private string nombre;
    private string modelo;
    private int tempMaquina;
    private int horasFuncionamiento;
    private int cantidadPiezas;
    private string estado;

    public int Id{
        get{
           return id; 
        }
        set{
           if(value < 0){
            throw new ArgumentException("El Id no puede ser negavivo");
            } 
            id = value;
        }
    }
    public string Nombre{
        get{
           return nombre;
        }
        set{
            if (string.IsNullOrWhiteSpace(value)){
                throw new ArgumentException("El Nombre no puede estar vacio");
            }
        }
    }
    public string Modelo{
        get{
            return nodelo;
        }
        set{
            if (string.IsNullOrWhiteSpace(value)){
                throw new ArgumentException("El modelo no puede estar vacio");
            }
        }
    }
    public int TempMaquina{
        get{
            return tempMaquina;
        }
        set{
            if (value < 0){
                throw new ArgumentException("La temperatura no puede ser negaviva");
            }
        }
    }
    public int HorasFuncionamiento{
        get{
           return horasFuncionamiento;
        }
        set
        {
            if(value < 0){
                throw new ArgumentException("Las horas de Funcionamiento no puede ser negativa");
            }
        }
    }
    public int CantidadPiezas{
        get
        {
            return cantidadPiezas;
        }
        set
        {
            if(value < 0)
            {
                throw new ArgumentException("La cantidad de piezas no puede ser negativa");
            }
        }
    }
    public string Estado
    {
        get
        {
            return estado;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("El estado no puede estar vacio");
            }
        }
    }
    public Maquina(int id, string nombre, string modelo, int tempMaquina, int horasFuncionamiento, int cantidadPiezas, string estado)
    {
        this.id = id;
        this.nombre = nombre;
        this.modelo = modelo;
        this.tempMaquina = tempMaquina;
        this.horasFuncionamiento = horasFuncionamiento;
        this.cantidadPiezas = cantidadPiezas;
        this.estado = estado;
    }
    public void mostrarInformacion()
    {
        Console.WriteLine("Id: " + id);
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Temperatura: " + tempMaquina);
        Console.WriteLine("Horas de Funcionamiento: " + cantidadPiezas);
        Console.WriteLine("Cantidad de Piezas: " + cantidadPiezas);
        Console.WriteLine("Estado: " + estado);
        
    }

}