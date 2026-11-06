using System;
public class Program
{
    public static void Main(string[] args)
    {
        const int MAX_MAQUINAS = 10;
        int totaslMaquinas = 0;
        MaquinaIndustrial[] maquinas = new MaquinaIndustrial[MAX_MAQUINAS];
        int opcion;
        do{
            opcion = Funciones.mostrarMenu();
            switch(opcion)
            {
                case 1:
                   Funciones.RegistrarMaquinaIndustrial(maquinas, ref totaslMaquinas, MAX_MAQUINAS);
                    break;
                case 2:
                    Funciones.mostrarTodasLasMaquinas(maquinas, totaslMaquinas);
                    break;
                case 3:
                    Funciones.monitoreoCondiciones(maquinas, totaslMaquinas);
                    break;
                case 4:
                    Funciones.cambioEstadoMaquina(maquinas, totaslMaquinas);
                    break;
                case 5:
                    Funciones.establecerIntervaloMantenimiento(maquinas, totaslMaquinas);
                    break;
                case 6:
                    Funciones.modificarHorasFuncionamiento(maquinas, totaslMaquinas);
                    break;
                case 7:
                    Funciones.buscarMaquinaPorId(maquinas, totaslMaquinas);
                    break;
                case 8:
                    Funciones.buscarMaquinaPorEstado(maquinas, totaslMaquinas);
                    break;
                case 9:
                    Funciones.mostarEstadisticas(maquinas, totaslMaquinas);
                    break;
                case 10:
                    Funciones.guardarDatos(maquinas, ref totaslMaquinas);
                    break;
                case 11:
                    Funciones.CargarDatos(maquinas, ref totaslMaquinas);
                    break;
                case 12:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }

            
        }while(opcion != 12);
        


    }
}
