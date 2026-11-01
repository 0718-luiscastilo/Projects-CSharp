using System;
public class Program
{
    public static void Main(string[] args)
    {
        const int MAX_MAQUINAS = 10;
        int totaslMaquinas = 0;
        MaquinaIndustrial[] maquinas = new MaquinaIndustrial[MAX_MAQUINAS];

        /*maquinas[0] = new TornoCNC(1,"Torno CNC", "CNC-500", 85, 1200, 4500, "Operativa", 1000, 2.5, "Herramienta A");
        maquinas[0].mostrarInformacion();
        maquinas[1] = new Fresadora(2, "Fresadora", "FRES-300", 90, 800, 3000, "Operativa", 1500, 3, "Fresa B");    
        maquinas[1].mostrarInformacion();
        maquinas[2] = new BandaTransportadora(3, "Banda Transportadora", "BANDA-200", 70, 1500, 5000, "Operativa", 2.5, 10, 100);
        maquinas[2].mostrarInformacion();*/
        Funciones.RegistrarMaquinaIndustrial(maquinas, ref totaslMaquinas, MAX_MAQUINAS);


    }
}
