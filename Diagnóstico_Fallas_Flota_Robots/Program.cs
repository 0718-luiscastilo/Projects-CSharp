using System;
public class Programa{
    public static void Main(string[] args){
        const int MAX_ROBOT = 50;
        int totalRobots =0;
        RobotIndustrial[] robots = new RobotIndustrial[MAX_ROBOT];
        Funciones.RegistarRobot(robots, ref totalRobots,MAX_ROBOT);
        ReporteFalla[] reportes = new ReporteFalla[100];
        int contadorReportes = 0;

    }
}
