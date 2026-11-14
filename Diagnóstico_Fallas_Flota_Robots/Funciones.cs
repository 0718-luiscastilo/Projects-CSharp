using System;
    public class Funciones{
        public static void RegistarRobot(RobotIndustrial[] robot, ref int totalRobot, int MAX_ROBOT){
            if(totalRobot >= MAX_ROBOT){
                Console.WriteLine("No se pueden registrar mas robots. Se ha alcanzado el limite");
                return;
            }
            Console.WriteLine("Seleccione el tipo de Robot que quiere registrar");
            Console.WriteLine("1.- Robot de Ensamble");
            Console.WriteLine("2.- Robot de Soldadura");
            Console.WriteLine("3.- Robot de Tasporte");
            Console.WriteLine("Ingrese el numero corresopondiente");
            int opcion;
            while(!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
            {
                Console.WriteLine("Opción inválida. Por favor, ingrese un número válido (1-3): ");
            }
            switch (opcion){
                case 1:
                    //Id
                    Console.WriteLine("Ingrese el Id del Robot:");
                    int idRobotEnsamble;
                    while (!int.TryParse(Console.ReadLine(), out idRobotEnsamble) || idRobotEnsamble <= 0){
                        Console.WriteLine("El ID debe ser un número positivo. Ingrese nuevamente el ID del Robot: ");
                    }
                    for(int i=0; i < totalRobot; i++){
                        if(robot[i].Id == idRobotEnsamble){
                            Console.WriteLine("El Id ya existe. No se puede registar el robot");
                            return;
                        }
                    }
                    //Nombre
                    Console.WriteLine("Ingrese el nombre del Robot");
                    string nombreRobotEnsamble = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(nombreRobotEnsamble)){
                        Console.WriteLine("El nombre no puede estar vacío. Ingrese nuevamente el nombre del Robot: ");
                        nombreRobotEnsamble = Console.ReadLine() ?? "";
                    }
                    //Modelo
                    Console.WriteLine("Ingrese el modelo del Robot: ");
                    string modeloRobotEnsamble = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(modeloRobotEnsamble)){
                        Console.WriteLine("El modelo no puede estar vacío. Ingrese nuevamente el modelo del Robot: ");
                        modeloRobotEnsamble = Console.ReadLine() ?? "";
                    }
                    //Fabircante
                    Console.WriteLine("Ingrese el Fabricante del Robot: ");
                    string fabicanteRobotEnsamble = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(fabicanteRobotEnsamble)){
                        Console.WriteLine("El Fabicante no puede estar vacío. Ingrese nuevamente el fabricante de Robot: ");
                        fabicanteRobotEnsamble = Console.ReadLine() ?? "";
                    }
                    //Año
                    Console.WriteLine("Ingrese el año de Fabricacion del Robot: ");
                    int anioRoborEnsamble;
                    while (!int.TryParse(Console.ReadLine(), out anioRoborEnsamble) || anioRoborEnsamble < 0){
                        Console.WriteLine("El año de Fabricacion no puede ser negativo. Ingrese nuevamente el año de Fabricacion del Robot: ");
                    }
                    //Horas funcionamiento
                    Console.WriteLine("Ingrese las horas de Funcionanmiento del Robot: ");
                    double horasRoborEnsamble;
                    while (!double.TryParse(Console.ReadLine(), out horasRoborEnsamble) || horasRoborEnsamble <= 0){
                        Console.WriteLine("Las horas debe ser un número positivo. Ingrese nuevamente las horas: ");
                    }
                    //Temperatura 
                    Console.WriteLine("Ingrese la Temperatura del motor del Robot: ");
                    double tempRoborEnsamble;
                    while (!double.TryParse(Console.ReadLine(), out tempRoborEnsamble) || tempRoborEnsamble <= 0){
                        Console.WriteLine("La Temperatura debe ser un número positivo. Ingrese nuevamente la Temperatura del Robot: ");
                    }
                    //Estado
                    Console.WriteLine("Ingrese el estado del Robot: ");
                    string estadoRoborEnsamble = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(estadoRoborEnsamble)){
                        Console.WriteLine("El estado no puede estar vacío. Ingrese nuevamente el estado del Robot: ");
                        estadoRoborEnsamble = Console.ReadLine() ?? "";
                    }
                    while(!estadoRoborEnsamble.Equals("Opertivo", StringComparison.OrdinalIgnoreCase) && 
                    !estadoRoborEnsamble.Equals("En mantenimiento", StringComparison.OrdinalIgnoreCase) && 
                    !estadoRoborEnsamble.Equals("Fuera de servicio", StringComparison.OrdinalIgnoreCase)){
                        Console.WriteLine("Estado inválido. El estado debe ser 'Operativa', 'En mantenimiento' o 'Fuera de servicio'.");
                        Console.WriteLine("Ingrese el estado del Robot: ");
                        estadoRoborEnsamble = Console.ReadLine() ?? "";
                    }
                    //Cantidad de Fallas
                    Console.WriteLine("Ingrese las cantidad de Fallas del Robot: ");
                    int fallasRoborEnsamble;
                    while (!int.TryParse(Console.ReadLine(), out fallasRoborEnsamble) || fallasRoborEnsamble < 0){
                        Console.WriteLine("Las fallas no puede ser negativa. Ingrese nuevamente las Fallas del Robot: ");
                    }
                    Console.WriteLine("Ingrese la cantidad de piezas Ensambladas: ");
                    int pizasRoborEnsamble;
                    while (!int.TryParse(Console.ReadLine(), out pizasRoborEnsamble) || pizasRoborEnsamble < 0){
                        Console.WriteLine("La cantidad de piezas no puede ser negativo. Ingrese nuevamente la cantidad de piezas: ");
                    }
                    //Presicion milimetrica 
                    Console.WriteLine("Ingrese presicion milimetrica del Robot: ");
                    double presicionRoborEnsamble;
                    while (!double.TryParse(Console.ReadLine(), out presicionRoborEnsamble) || presicionRoborEnsamble <= 0){
                        Console.WriteLine("La precision milimetrica debe ser un número positivo. Ingrese nuevamente la presicion milimetrica: ");
                    }
                    //Tipo de Herramienta
                    Console.WriteLine("Ingrese El tipo de Herramienta del Robot: ");
                    string herramientaRoborEnsamble = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(herramientaRoborEnsamble)){
                        Console.WriteLine("El Tipo de herramienta no puede estar vacío. Ingrese nuevamente el Tipo de Herramienta del Robot: ");
                        herramientaRoborEnsamble = Console.ReadLine() ?? "";
                    }
                    RobotIndustrial robotEnsamble = new RobotEnsamblaje(idRobotEnsamble,nombreRobotEnsamble,modeloRobotEnsamble,fabicanteRobotEnsamble,
                    anioRoborEnsamble,horasRoborEnsamble,tempRoborEnsamble,estadoRoborEnsamble,fallasRoborEnsamble,pizasRoborEnsamble,
                    presicionRoborEnsamble,herramientaRoborEnsamble);
                    robot[totalRobot] = robotEnsamble;
                    totalRobot++;
                    Console.WriteLine("El robor se agrego con Exito");
                break;
                case 2:
                    //ID
                    Console.WriteLine("Ingrese el Id del Robot:");
                    int idRobotSoldadura;
                    while (!int.TryParse(Console.ReadLine(), out idRobotSoldadura) || idRobotSoldadura <= 0){
                        Console.WriteLine("El ID debe ser un número positivo. Ingrese nuevamente el ID del Robot: ");
                    }
                    for(int i=0; i < totalRobot; i++){
                        if(robot[i].Id == idRobotSoldadura){
                            Console.WriteLine("El Id ya existe. No se puede registar el robot");
                            return;
                        }
                    }
                    //Nombre
                    Console.WriteLine("Ingrese el nombre del robot;");
                    string nombreRobotSoldadura = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(nombreRobotSoldadura)){
                        Console.WriteLine("El nombre no puede estar vacío. Ingrese nuevamente el nombre del robot ");
                        nombreRobotSoldadura = Console.ReadLine() ?? "";
                    }
                    //Modelo
                    Console.WriteLine("Ingrese el modelo del robot: ");
                    string modeloRobotSoldadura = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(modeloRobotSoldadura))
                    {
                        Console.WriteLine("El modelo no puede estar vacío. Ingrese nuevamente el modelo del robot: ");
                        modeloRobotSoldadura = Console.ReadLine() ?? "";
                    }
                    //Fabircante
                    Console.WriteLine("Ingrese el Fabricante del robot: ");
                    string fabicanteRoboSoldadura = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(fabicanteRoboSoldadura)){
                        Console.WriteLine("El Fabicante no puede estar vacío. Ingrese nuevamente el modelo del robot: ");
                        fabicanteRoboSoldadura = Console.ReadLine() ?? "";
                    }
                    //Año
                    Console.WriteLine("Ingrese el año de Fabricacion del Robot: ");
                    int anioRoborSoldadura;
                    while (!int.TryParse(Console.ReadLine(), out anioRoborSoldadura) || anioRoborSoldadura < 0){
                        Console.WriteLine("El año de Fabricacion no puede ser negativo. Ingrese nuevamente el año de Fabricacion del Robot: ");
                    }
                    //Horas funcionamiento
                    Console.WriteLine("Ingrese las horas de Funcionanmiento del Robot: ");
                    double horasRoborSoldadura;
                    while (!double.TryParse(Console.ReadLine(), out horasRoborSoldadura) || horasRoborSoldadura <= 0){
                        Console.WriteLine("Las horas debe ser un número positivo. Ingrese nuevamente las horas: ");
                    }
                    //Temperatura 
                    Console.WriteLine("Ingrese la Temperatura del motor del Robot: ");
                    double tempMotorRoborSoldadura;
                    while (!double.TryParse(Console.ReadLine(), out tempMotorRoborSoldadura) || tempMotorRoborSoldadura <= 0){
                        Console.WriteLine("La Temperatura debe ser un número positivo. Ingrese nuevamente la Temperatura del Robot: ");
                    }
                    //Estado
                    Console.WriteLine("Ingrese el estado del Robot: ");
                    string estadoRoborSoldadura = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(estadoRoborSoldadura)){
                        Console.WriteLine("El estado no puede estar vacío. Ingrese nuevamente el estado del Robot: ");
                        estadoRoborSoldadura = Console.ReadLine() ?? "";
                    }
                    while(!estadoRoborSoldadura.Equals("Operativo", StringComparison.OrdinalIgnoreCase) && 
                    !estadoRoborSoldadura.Equals("En mantenimiento", StringComparison.OrdinalIgnoreCase) && 
                    !estadoRoborSoldadura.Equals("Fuera de servicio", StringComparison.OrdinalIgnoreCase)){
                        Console.WriteLine("Estado inválido. El estado debe ser 'Operativo', 'En mantenimiento' o 'Fuera de servicio'.");
                        Console.WriteLine("Ingrese el estado del Robot: ");
                        estadoRoborSoldadura = Console.ReadLine() ?? "";
                    }
                    //Cantidad de Fallas
                    Console.WriteLine("Ingrese las cantidad de Fallas del Robot: ");
                    int fallasRoborSoldadura;
                    while (!int.TryParse(Console.ReadLine(), out fallasRoborSoldadura) || fallasRoborSoldadura < 0){
                        Console.WriteLine("Las fallas no puede ser negativa. Ingrese nuevamente las Fallas del Robot: ");
                    }
                    //Tempertura de Soldadura
                    Console.WriteLine("Ingrese la Temperatura de Soldadura del Robot: ");
                    double tempRoborSoldadura;
                    while (!double.TryParse(Console.ReadLine(), out tempRoborSoldadura) || tempRoborSoldadura <= 0){
                        Console.WriteLine("La Temperatura de Soldadura debe ser un número positivo. Ingrese nuevamente La temperatura de Soldadura del Robot: ");
                    }
                    //Tipo Soldadura 
                    Console.WriteLine("Ingrese el tipo de Soldadura Robot: ");
                    string tipoRoborSoldadura = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(tipoRoborSoldadura)){
                        Console.WriteLine("El tipo de soldadura no puede estar vacío. Ingrese nuevamente el tipo de soldadurs del Robot: ");
                        tipoRoborSoldadura = Console.ReadLine() ?? "";
                    }
                    //Cantidad de Soldaduras
                    Console.WriteLine("Ingrese la cantidad de Soldaduras del Robot: ");
                    int cantidadRoborSoldadura;
                    while (!int.TryParse(Console.ReadLine(), out cantidadRoborSoldadura) || cantidadRoborSoldadura < 0){
                        Console.WriteLine("La cantidad de Soldaduras no puede ser negativa. Ingrese nuevamente las cantidad de soldaduras del Robot: ");
                    }
                    RobotIndustrial roborSoldadura = new RobotSoldadura(idRobotSoldadura,nombreRobotSoldadura,modeloRobotSoldadura,fabicanteRoboSoldadura,
                    anioRoborSoldadura,horasRoborSoldadura,tempMotorRoborSoldadura,estadoRoborSoldadura,fallasRoborSoldadura,tempRoborSoldadura,
                    tipoRoborSoldadura,cantidadRoborSoldadura);
                    robot[totalRobot] = roborSoldadura;
                    totalRobot++;
                    Console.WriteLine("El Robot se agrego con Exito");
                break;
                case 3:
                    //Id
                    Console.WriteLine("Ingrese el Id del Robot:");
                    int idRobotTrasporte;
                    while (!int.TryParse(Console.ReadLine(), out idRobotTrasporte) || idRobotTrasporte <= 0){
                        Console.WriteLine("El ID debe ser un número positivo. Ingrese nuevamente el ID del Robot: ");
                    }
                    for(int i=0; i < totalRobot; i++){
                        if(robot[i].Id == idRobotTrasporte){
                            Console.WriteLine("El Id ya existe. No se puede registar el robot");
                            return;
                        }
                    }
                    //Nombre
                    Console.WriteLine("Ingrese el nombre del Robot;");
                    string nombreRobotTrasporte = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(nombreRobotTrasporte)){
                        Console.WriteLine("El nombre no puede estar vacío. Ingrese nuevamente el nombre del Robot: ");
                        nombreRobotTrasporte = Console.ReadLine() ?? "";
                    }
                    //Modelo
                    Console.WriteLine("Ingrese el modelo delRobot: ");
                    string modeloRobotTrasporte = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(modeloRobotTrasporte)){
                        Console.WriteLine("El modelo no puede estar vacío. Ingrese nuevamente el modelo del Robot: ");
                        modeloRobotTrasporte = Console.ReadLine() ?? "";
                    }
                    //Fabircante
                    Console.WriteLine("Ingrese el Fabicante del Robot: ");
                    string fabicanteRoboTrasporte = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(fabicanteRoboTrasporte)){
                        Console.WriteLine("El Fabicante no puede estar vacío. Ingrese nuevamente el Fabricante del Robot: ");
                        fabicanteRoboTrasporte = Console.ReadLine() ?? "";
                    }
                    //Año
                    Console.WriteLine("Ingrese el año de Fabricacion del Robot: ");
                    int anioRoborTrasporte;
                    while (!int.TryParse(Console.ReadLine(), out anioRoborTrasporte) || anioRoborTrasporte < 0){
                        Console.WriteLine("El año de Fabricacion no puede ser negativo. Ingrese nuevamente el año de Fabricacion del Robot: ");
                    }
                    //Horas funcionamiento
                    Console.WriteLine("Ingrese las horas de Funcionanmiento del Robot: ");
                    double horasRoborTrasporte;
                    while (!double.TryParse(Console.ReadLine(), out horasRoborTrasporte) || horasRoborTrasporte <= 0){
                        Console.WriteLine("Las horas debe ser un número positivo. Ingrese nuevamente las horas: ");
                    }
                    //Temperatura 
                    Console.WriteLine("Ingrese la Temperatura del motor del Robot: ");
                    double tempRoborTrasporte;
                    while (!double.TryParse(Console.ReadLine(), out tempRoborTrasporte) || tempRoborTrasporte <= 0){
                        Console.WriteLine("La Temperatura debe ser un número positivo. Ingrese nuevamente la Temperatura del Robot: ");
                    }
                    //Estado
                    Console.WriteLine("Ingrese el estado del Robot: ");
                    string estadoRoborTrasporte = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(estadoRoborTrasporte)){
                        Console.WriteLine("El estado no puede estar vacío. Ingrese nuevamente el estado del Robot: ");
                        estadoRoborTrasporte = Console.ReadLine() ?? "";
                    }
                    while(!estadoRoborTrasporte.Equals("Operativo", StringComparison.OrdinalIgnoreCase) && 
                    !estadoRoborTrasporte.Equals("En mantenimiento", StringComparison.OrdinalIgnoreCase) && 
                    !estadoRoborTrasporte.Equals("Fuera de servicio", StringComparison.OrdinalIgnoreCase)){
                        Console.WriteLine("Estado inválido. El estado debe ser 'Operativo', 'En mantenimiento' o 'Fuera de servicio'.");
                        Console.WriteLine("Ingrese el estado del Robot: ");
                        estadoRoborTrasporte = Console.ReadLine() ?? "";
                    }
                    //Cantidad de Fallas
                    Console.WriteLine("Ingrese las cantidad de Fallas del Robot: ");
                    int fallasRoborTrasporte;
                    while (!int.TryParse(Console.ReadLine(), out fallasRoborTrasporte) || fallasRoborTrasporte < 0){
                        Console.WriteLine("Las fallas no puede ser negativa. Ingrese nuevamente las Fallas del Robot: ");
                    }
                    //Capacidad de Carga
                    Console.WriteLine("Ingrese la Capacidad de carga del Robot: ");
                    double capacidadRoborTrasporte;
                    while (!double.TryParse(Console.ReadLine(), out capacidadRoborTrasporte) || capacidadRoborTrasporte <= 0){
                        Console.WriteLine("La capacidadde carga debe ser un número positivo. Ingrese nuevamente la capacidad de carga del Robot: ");
                    }
                    //Velocidad Trasporte 
                    Console.WriteLine("Ingrese la Velocidad de trasporte del Robot: ");
                    double velocidadRoborTrasporte;
                    while (!double.TryParse(Console.ReadLine(), out velocidadRoborTrasporte) || velocidadRoborTrasporte <= 0){
                        Console.WriteLine("La velocidad de trasporte debe ser un número positivo. Ingrese nuevamente la capacidad de velocidad de trasporte del Robot: ");
                    }
                    //Distancia Recorida
                    Console.WriteLine("Ingrese la -Distancia Recorida del Robot: ");
                    double distanciaRoborTrasporte;
                    while (!double.TryParse(Console.ReadLine(), out distanciaRoborTrasporte) || distanciaRoborTrasporte <= 0){
                        Console.WriteLine("La distancia Recorida debe ser un número positivo. Ingrese nuevamente la distancia recorida del Robot: ");
                    }
                    RobotIndustrial roborTrasporte = new RobotTransporte(idRobotTrasporte,nombreRobotTrasporte,modeloRobotTrasporte,fabicanteRoboTrasporte,
                    anioRoborTrasporte,horasRoborTrasporte,tempRoborTrasporte,estadoRoborTrasporte,fallasRoborTrasporte,capacidadRoborTrasporte,
                    velocidadRoborTrasporte,distanciaRoborTrasporte);
                    robot[totalRobot] = roborTrasporte;
                    totalRobot++;
                    Console.WriteLine("El Robot se agrego con Exito");                  
                break;
            }
        }
        public static void MostrarTodoslosRobots(RobotIndustrial[] robots, int totalRobots){
            if(totalRobots == 0){
                Console.WriteLine("No hay ningun robot registrado.");
                return;
            }
            for(int i=0; i<totalRobots; i++){
                robots[i].MostrarInformacion();
            }
        }
        public static void MostrarRobotporId(RobotIndustrial[] robots, int totalRobots){
            if(totalRobots == 0){
                Console.WriteLine("No hay ningun robot registrado.");
                return;
            }
            Console.WriteLine("Ingrese el Id del Robot");
            int idBuscar;
            while(!int.TryParse(Console.ReadLine(), out idBuscar) || idBuscar <= 0){
                Console.WriteLine("El ID debe ser un numero positivo. Ingrese nuevamente el ID");
            }
            int index =-1;
            for(int i =0; i < totalRobots; i++){
                if(robots[i].Id == idBuscar){
                    index =i;
                    break;
                }
            }
            if(index == -1){
                Console.WriteLine("No se encontro ningun robot con ese Id");
            }
            robots[index].MostrarInformacion();
        }
        public static void MostarRobotporFabricante(RobotIndustrial[] robots, int totalRobots){
            if(totalRobots == 0){
                Console.WriteLine("No hay ningun robot registrado.");
                return;
            }
            Console.WriteLine("Ingrese el Fabricante del Robot");
            string fabitanteBuscar = Console.ReadLine() ?? "";
            while (string.IsNullOrWhiteSpace(fabitanteBuscar)){
                Console.WriteLine("El Fabricante a bucar no puede estar vacío. Ingrese nuevamente el nombre del Fabricante del Robot: ");
                fabitanteBuscar = Console.ReadLine() ?? "";
            }
            bool encontrado =false;
            for(int i =0; i < totalRobots; i++){
                if (robots[i].Fabricante.Equals(fabitanteBuscar, StringComparison.OrdinalIgnoreCase)){
                    robots[i].MostrarInformacion();
                    Console.WriteLine("--------------------");
                    encontrado = true;
                }
            }
            if (!encontrado){
                Console.WriteLine($"No se encontro ningun robon con el fabricante {fabitanteBuscar}");
            }
        }
        public static void ActualizarEstado(RobotIndustrial[] robots, int totalRobots){
            if(totalRobots == 0){
                Console.WriteLine("No hay ningun robot registrado.");
                return;
            }
            Console.WriteLine("Ingrese el Id del Robot");
            int idCambioEstado;
            while(!int.TryParse(Console.ReadLine(), out idCambioEstado) || idCambioEstado <= 0){
                Console.WriteLine("El ID debe ser un numero positivo. Ingrese nuevamente el ID");
            }
            int index =-1;
            for(int i =0; i < totalRobots; i++){
                if(robots[i].Id == idCambioEstado){
                    index =i;
                    break;
                }
            }
            if(index == -1){
                Console.WriteLine("No se encontro ningun robot con ese Id");
            }
            Console.WriteLine("Ingrese el nuevo estado del Robot (Operativo, En mantenimiento, Fuera de servicio): ");
            string nuevoEstado = Console.ReadLine() ?? "";
            while(!nuevoEstado.Equals("Operatvo", StringComparison.OrdinalIgnoreCase) && 
                  !nuevoEstado.Equals("En mantenimiento", StringComparison.OrdinalIgnoreCase) && 
                  !nuevoEstado.Equals("Fuera de servicio", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Estado inválido. El estado debe ser 'Operativa', 'En mantenimiento' o 'Fuera de servicio'.");
                Console.WriteLine("Ingrese el nuevo estado de la máquina: ");
                nuevoEstado = Console.ReadLine() ?? "";
            }
            robots[index].Estado = nuevoEstado;
            Console.WriteLine($"El estado del Robot {robots[index].Nombre} ha sido cambiado a {nuevoEstado}.");
        }
        public static void MofificarHoras(RobotIndustrial[] robots, int totalRobots){
            if(totalRobots == 0){
                Console.WriteLine("No hay ningun robot registrado.");
                return;
            }
            Console.WriteLine("Ingrese el Id del Robot");
            int idCambioHoras;
            while(!int.TryParse(Console.ReadLine(), out idCambioHoras) || idCambioHoras <= 0){
                Console.WriteLine("El ID debe ser un numero positivo. Ingrese nuevamente el ID");
            }
            int index =-1;
            for(int i =0; i < totalRobots; i++){
                if(robots[i].Id == idCambioHoras){
                    index =i;
                    break;
                }
            }
            if(index == -1){
                Console.WriteLine("No se encontro ningun robot con ese Id");
            }
            Console.WriteLine("Ingrese las nuevas horas de funcionamiento");
            int nuevasHoras;
            while (!int.TryParse(Console.ReadLine(), out nuevasHoras) || nuevasHoras < 0){
                Console.WriteLine("Las horas de funcionamiento no pueden ser negativas. Ingrese nuevamente las horas de funcionamiento: ");
            }
            robots[index].HorasFuncionamiento = nuevasHoras;
            Console.WriteLine($"Las horas de funcionamiento del Robot {robots[index].Nombre} han sido actualizadas a {nuevasHoras} horas.");
        }
        public static void EjecutarDiagnostico(RobotIndustrial[] robots, int totalRobots){
            if(totalRobots == 0){
                Console.WriteLine("No hay ningun robot registrado.");
                return;
            }
            Console.WriteLine("Ingrese el Id del Robot");
            int idCambioHoras;
            while(!int.TryParse(Console.ReadLine(), out idCambioHoras) || idCambioHoras <= 0){
                Console.WriteLine("El ID debe ser un numero positivo. Ingrese nuevamente el ID");
            }
            int index =-1;
            for(int i =0; i < totalRobots; i++){
                if(robots[i].Id == idCambioHoras){
                    index =i;
                    break;
                }
            }
            if(index == -1){
                Console.WriteLine("No se encontro ningun robot con ese Id");
            }
            Console.WriteLine($"ID: {robots[index].Id}.");
            Console.WriteLine($"Nombre: {robots[index].Nombre}.");
            Console.WriteLine($"Modelo: {robots[index].Modelo}.");
            Console.WriteLine($"Temperatura del Motor: {robots[index].TemperaturaMotor}.");
            Console.WriteLine($"Horas de Funcionamiento: {robots[index].HorasFuncionamiento}.");
            Console.WriteLine($"Estado: {robots[index].Estado}.");

            if(robots[index].HorasFuncionamiento > 2000){
                Console.WriteLine("Condicion Detectada: MANTENIMIENTO REQUERIDO");
            }else{
                Console.WriteLine("Condicion Detectada: NO REQUIERE MANTENIMIENTO");
            }        
        }
    }
