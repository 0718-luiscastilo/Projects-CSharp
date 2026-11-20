using System;
public class Programa{
    public static void Main(string[] args){
        const int MAX_ROBOT = 50;
        int totalRobots =0;
        RobotIndustrial[] robots = new RobotIndustrial[MAX_ROBOT];
        ReporteFalla[] reportes = new ReporteFalla[100];
        int contadorReportes = 0;
        int opcion;
        do{
            opcion = Funciones.mostrarMenu();
            switch(opcion)
            {
                case 1:
                   Funciones.RegistarRobot(robots, ref totalRobots, MAX_ROBOT);
                    break;
                case 2:
                    Funciones.MostrarTodoslosRobots(robots,totalRobots);
                    break;
                case 3:
                    Funciones.MostrarRobotporId(robots, totalRobots);
                    break;
                case 4:
                    Funciones.MostarRobotporFabricante(robots, totalRobots);
                    break;
                case 5:
                    Funciones.ActualizarEstado(robots, totalRobots);
                    break;
                case 6:
                    Funciones.ModificarHoras(robots,totalRobots);
                    break;
                case 7:
                    Funciones.EjecutarDiagnostico(robots, totalRobots);
                    break;
                case 8:
                    Funciones.MostarRobotRequiereMtto(robots,totalRobots);
                    break;
                case 9:
                    Funciones.RegistarReporteFalla(reportes, ref contadorReportes, robots, totalRobots);
                    break;
                case 10:
                    Funciones.ConsultarReporte(reportes,contadorReportes);
                    break;
                case 11:
                    Funciones.ActualizarEstadoFalla(reportes,contadorReportes);
                    break;
                case 12:
                    Funciones.GenerarReporteRobot(robots,totalRobots);
                    break;
                case 13:
                    Funciones.GenerarReporteFalla(reportes,contadorReportes);
                    break;
                case 14:
                    Funciones.guardarRobots(robots,totalRobots);
                    break;
                case 15:
                    Funciones.CargarRobots(robots, ref totalRobots);
                    break;
                case 16:
                    Funciones.GenerarReporteFalla(reportes,contadorReportes);
                    break;
                case 17:
                    Funciones.CargarFalla(reportes, contadorReportes);
                    break;
                case 18:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                    break;
            }

            
        }while(opcion != 18);

    }
}
