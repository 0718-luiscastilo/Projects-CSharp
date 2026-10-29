using System;
public class MaquinaIndustrial{
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
            nombre = value;
        }
    }
    public string Modelo{
        get{
            return modelo;
        }
        set{
            if (string.IsNullOrWhiteSpace(value)){
                throw new ArgumentException("El modelo no puede estar vacio");
            }
            modelo = value;
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
            horasFuncionamiento = value;
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
            cantidadPiezas = value;
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
            estado = value;
        }
    }
    public MaquinaIndustrial(int id, string nombre, string modelo, int tempMaquina, int horasFuncionamiento, int cantidadPiezas, string estado)
    {
        this.id = id;
        this.nombre = nombre;
        this.modelo = modelo;
        this.tempMaquina = tempMaquina;
        this.horasFuncionamiento = horasFuncionamiento;
        this.cantidadPiezas = cantidadPiezas;
        this.estado = estado;
    }
    public void condicionMaquina()
    {
        if(tempMaquina < 60)
        {
            Console.WriteLine("La temeperatura de la maquina esta Normal");
        } else if(tempMaquina > 60 && tempMaquina < 80)
        {
            Console.WriteLine("Adertencia. La temeperatura esta alta");
        }else
        {
            Console.WriteLine("Critica. La Temperatura esta demasiado alta");
        }
    }

    public void mostrarInformacion()
    {
        Console.WriteLine("Id: " + id);
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Modelo: " + modelo);
        Console.WriteLine("Temperatura: " + tempMaquina);
        Console.WriteLine("Horas de Funcionamiento: " + horasFuncionamiento);
        Console.WriteLine("Cantidad de Piezas: " + cantidadPiezas);
        Console.WriteLine("Estado: " + estado);
        
    }

}