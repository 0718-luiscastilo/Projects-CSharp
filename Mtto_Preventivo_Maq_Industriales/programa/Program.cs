using System;
public class Program
{
    public static void Main(string[] args)
    {
        MaquinaIndustrial maquina = new MaquinaIndustrial(1,"Torno CNC", "CNC-500", 85, 1200, 4500, "Operativa" );
        maquina.mostrarInformacion();
        Console.WriteLine();
        maquina.condicionMaquina();
        
    }
}
