using System;
public class Program{
    public static void Main(string[] args){
        const int MAX_INCIDENCIAS =100;
        int totalIncidencias =0;
        Incidencia[] incidencias = new Incidencia[MAX_INCIDENCIAS];
        int op;
        do{
            op = GestorIncidencias.MostrarMenu();
            switch(op){
                case 1:
                GestorIncidencias.RegistrarIncidencia(incidencias, ref totalIncidencias, MAX_INCIDENCIAS);
                break;
                case 2:
                GestorIncidencias.MostrarTodasLasIncidencias(incidencias, totalIncidencias);
                break;
                case 3:
                GestorIncidencias.BuscarPorIdentificador(incidencias, totalIncidencias);
                break;
                case 4:
                GestorIncidencias.BuscarPorEmpleado(incidencias, totalIncidencias);
                break;
                case 5:
                GestorIncidencias.FiltrarPorPrioridad(incidencias, totalIncidencias);
                break;
                case 6:
                GestorIncidencias.FiltrarPorEstado(incidencias, totalIncidencias);
                break;
                case 7:
                GestorIncidencias.FiltrarPorTipo(incidencias, totalIncidencias);
                break;
                case 8:
                GestorIncidencias.CambiarEstado(incidencias, totalIncidencias);
                break;
                case 9:
                GestorIncidencias.MostrarResumenEstadistico(incidencias, totalIncidencias);
                break;
                case 10:
                Console.WriteLine("Gracias por utilizar el Sistema.");
                break;
                default:
                Console.WriteLine("Opción no reconocida.");
                break;
            }
        }while(op != 10);
    }
}