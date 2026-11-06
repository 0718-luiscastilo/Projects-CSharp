using System;
using System.IO;
using System.Text;
    public class Funciones
    {
        public static void RegistrarMaquinaIndustrial(MaquinaIndustrial[] maquinas,  ref int totalMaquinas, int MAX_MAQUINAS){
            if (totalMaquinas >= MAX_MAQUINAS){
                Console.WriteLine("No se pueden registrar más máquinas. Se ha alcanzado el límite máximo.");
                return;
            }
            Console.WriteLine("Seleccione el tipo de máquina a registrar:");
            Console.WriteLine("1. Torno CNC"); 
            Console.WriteLine("2. Fresadora");
            Console.WriteLine("3. Banda Transportadora");   
            Console.Write("Ingrese el número correspondiente al tipo de máquina: ");
            int opcion;
            while(!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 3)
            {
                Console.WriteLine("Opción inválida. Por favor, ingrese un número válido (1-3): ");
            }
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Ingrese el ID de la máquina: ");
                    int idTorno;
                    while (!int.TryParse(Console.ReadLine(), out idTorno) || idTorno <= 0)
                    {
                        Console.WriteLine("El ID debe ser un número positivo. Ingrese nuevamente el ID de la máquina: ");
                    }
                    for (int i = 0; i < totalMaquinas; i++){
                        if (maquinas[i].Id == idTorno){
                            Console.WriteLine("El ID ingresado ya existe. No se puede registrar la máquina.");
                            return;
                        }
                    }
                    Console.WriteLine("Ingrese el nombre de la máquina: ");
                    string nombreTorno = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(nombreTorno))
                    {
                        Console.WriteLine("El nombre no puede estar vacío. Ingrese nuevamente el nombre de la máquina: ");
                        nombreTorno = Console.ReadLine() ?? "";
                    }
                    Console.WriteLine("Ingrese el modelo de la máquina: ");
                    string modeloTorno = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(modeloTorno))
                    {
                        Console.WriteLine("El modelo no puede estar vacío. Ingrese nuevamente el modelo de la máquina: ");
                        modeloTorno = Console.ReadLine() ?? "";
                    }
                    Console.WriteLine("Ingrese la temperatura de la máquina: ");
                    int tempMaquinaTorno;
                    while (!int.TryParse(Console.ReadLine(), out tempMaquinaTorno) || tempMaquinaTorno < 0)
                    {
                        Console.WriteLine("La temperatura no puede ser negativa. Ingrese nuevamente la temperatura de la máquina: ");
                    }
                    Console.WriteLine("Ingrese las horas de funcionamiento de la máquina: ");
                    int horasFuncionamientoTorno;
                    while (!int.TryParse(Console.ReadLine(), out horasFuncionamientoTorno) || horasFuncionamientoTorno < 0)
                    {
                        Console.WriteLine("Las horas de funcionamiento no pueden ser negativas. Ingrese nuevamente las horas de funcionamiento de la máquina: ");
                    }
                    Console.WriteLine("Ingrese la cantidad de piezas producidas por la máquina: ");
                    int cantidadPiezasTorno;
                    while (!int.TryParse(Console.ReadLine(), out cantidadPiezasTorno) || cantidadPiezasTorno < 0)
                    {
                        Console.WriteLine("La cantidad de piezas no puede ser negativa. Ingrese nuevamente la cantidad de piezas producidas por la máquina: ");
                    }
                    Console.WriteLine("Ingrese el estado de la máquina: ");
                    string estadoTorno = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(estadoTorno))
                    {
                        Console.WriteLine("El estado no puede estar vacío. Ingrese nuevamente el estado de la máquina: ");
                        estadoTorno = Console.ReadLine() ?? "";
                    }
                    while(!estadoTorno.Equals("Operativa", StringComparison.OrdinalIgnoreCase) && 
                    !estadoTorno.Equals("En mantenimiento", StringComparison.OrdinalIgnoreCase) && 
                    !estadoTorno.Equals("Fuera de servicio", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Estado inválido. El estado debe ser 'Operativa', 'En mantenimiento' o 'Fuera de servicio'.");
                        Console.WriteLine("Ingrese el estado de la máquina: ");
                        estadoTorno = Console.ReadLine() ?? "";
                    }
                    Console.WriteLine("Ingrese la velocidad del husillo: ");
                    int velocidadHusillo;
                    while (!int.TryParse(Console.ReadLine(), out velocidadHusillo) || velocidadHusillo < 0)
                    {
                        Console.WriteLine("La velocidad del husillo no puede ser negativa. Ingrese nuevamente la velocidad del husillo: ");
                    }
                    Console.WriteLine("Ingrese el diámetro máximo: ");
                    double diametroMaximo;
                    while (!double.TryParse(Console.ReadLine(), out diametroMaximo) || diametroMaximo <= 0)
                    {
                        Console.WriteLine("El diámetro máximo debe ser un número positivo. Ingrese nuevamente el diámetro máximo: ");
                    }
                    
                    Console.WriteLine("Ingrese el tipo de herramienta: ");
                    string tipoHerramienta = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(tipoHerramienta))
                    {
                        Console.WriteLine("El tipo de herramienta no puede estar vacío. Ingrese nuevamente el tipo de herramienta: ");
                        tipoHerramienta = Console.ReadLine() ?? "";
                    }   
                    
                    MaquinaIndustrial torno = new TornoCNC(idTorno, nombreTorno, modeloTorno, tempMaquinaTorno, horasFuncionamientoTorno, cantidadPiezasTorno, estadoTorno, velocidadHusillo, diametroMaximo, tipoHerramienta);
                    maquinas[totalMaquinas] = torno;
                    totalMaquinas++;
                    Console.WriteLine($"La máquina {nombreTorno} ha sido registrada exitosamente.");
                    break;
                case 2:
                    Console.WriteLine("Ingrese el ID de la máquina: ");
                    int idFresadora;
                    while (!int.TryParse(Console.ReadLine(), out idFresadora) || idFresadora <= 0)
                    {
                        Console.WriteLine("El ID debe ser un número positivo. Ingrese nuevamente el ID de la máquina: ");
                    }
                    for (int i = 0; i < totalMaquinas; i++){
                        if (maquinas[i].Id == idFresadora){
                            Console.WriteLine("El ID ingresado ya existe. No se puede registrar la máquina.");
                            return;
                        }
                    }
                    Console.WriteLine("Ingrese el nombre de la máquina: ");
                    string nombreFresadora = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(nombreFresadora))
                    {
                        Console.WriteLine("El nombre no puede estar vacío. Ingrese nuevamente el nombre de la máquina: ");
                        nombreFresadora = Console.ReadLine() ?? "";
                    }
                    Console.WriteLine("Ingrese el modelo de la máquina: ");
                    string modeloFresadora = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(modeloFresadora))
                    {
                        Console.WriteLine("El modelo no puede estar vacío. Ingrese nuevamente el modelo de la máquina: ");
                        modeloFresadora = Console.ReadLine() ?? "";
                    }
                    Console.WriteLine("Ingrese la temperatura de la máquina: ");
                    int tempMaquinaFresadora;
                    while (!int.TryParse(Console.ReadLine(), out tempMaquinaFresadora) || tempMaquinaFresadora < 0)
                    {
                        Console.WriteLine("La temperatura no puede ser negativa. Ingrese nuevamente la temperatura de la máquina: ");
                    }
                    Console.WriteLine("Ingrese las horas de funcionamiento de la máquina: ");
                    int horasFuncionamientoFresadora;
                    while (!int.TryParse(Console.ReadLine(), out horasFuncionamientoFresadora) || horasFuncionamientoFresadora < 0)
                    {
                        Console.WriteLine("Las horas de funcionamiento no pueden ser negativas. Ingrese nuevamente las horas de funcionamiento de la máquina: ");
                    }   
                    Console.WriteLine("Ingrese la cantidad de piezas producidas por la máquina: ");
                    int cantidadPiezasFresadora;
                    while (!int.TryParse(Console.ReadLine(), out cantidadPiezasFresadora) || cantidadPiezasFresadora < 0)
                    {
                        Console.WriteLine("La cantidad de piezas no puede ser negativa. Ingrese nuevamente la cantidad de piezas producidas por la máquina: ");
                    }
                    Console.WriteLine("Ingrese el estado de la máquina: ");
                    string estadoFresadora = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(estadoFresadora))
                    {
                        Console.WriteLine("El estado no puede estar vacío. Ingrese nuevamente el estado de la máquina: ");
                        Console.WriteLine("Ingrese el estado de la máquina: ");
                        estadoFresadora = Console.ReadLine() ?? "";
                    }
                    while(!estadoFresadora.Equals("Operativa", StringComparison.OrdinalIgnoreCase) && 
                    !estadoFresadora.Equals("En mantenimiento", StringComparison.OrdinalIgnoreCase) && 
                    !estadoFresadora.Equals("Fuera de servicio", StringComparison.OrdinalIgnoreCase))   
                    {
                        Console.WriteLine("Estado inválido. El estado debe ser 'Operativa', 'En mantenimiento' o 'Fuera de servicio'.");
                        Console.WriteLine("Ingrese el estado de la máquina: ");
                        estadoFresadora = Console.ReadLine() ?? "";
                    }
                    Console.WriteLine("Ingrese la velocidad de corte: ");
                    double velocidadCorte;
                    while (!double.TryParse(Console.ReadLine(), out velocidadCorte) || velocidadCorte < 0)
                    {
                        Console.WriteLine("La velocidad de corte no puede ser negativa. Ingrese nuevamente la velocidad de corte: ");
                    }
                    Console.WriteLine("Ingrese el número de ejes: ");
                    int numeroEjes;
                    while (!int.TryParse(Console.ReadLine(), out numeroEjes) || numeroEjes <= 0)
                    {
                        Console.WriteLine("El número de ejes debe ser un número positivo. Ingrese nuevamente el número de ejes: ");
                    }
                    Console.WriteLine("Ingrese el tipo de fresa: ");
                    string tipoFresa = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(tipoFresa))
                    {
                        Console.WriteLine("El tipo de fresa no puede estar vacío. Ingrese nuevamente el tipo de fresa: ");
                        tipoFresa = Console.ReadLine() ?? "";
                    }

                    MaquinaIndustrial fresadora = new Fresadora(idFresadora, nombreFresadora, modeloFresadora, tempMaquinaFresadora, horasFuncionamientoFresadora, cantidadPiezasFresadora, estadoFresadora, velocidadCorte, numeroEjes, tipoFresa);
                    maquinas[totalMaquinas] = fresadora;
                    totalMaquinas++;
                    Console.WriteLine($"La máquina {nombreFresadora} ha sido registrada exitosamente.");
                    break;
                case 3:
                    Console.WriteLine("Ingrese el ID de la máquina: ");
                    int idBandaTransportadora;
                    while (!int.TryParse(Console.ReadLine(), out idBandaTransportadora) || idBandaTransportadora <= 0)
                    {
                        Console.WriteLine("El ID debe ser un número positivo. Ingrese nuevamente el ID de la máquina: ");
                    }
                    for (int i = 0; i < totalMaquinas; i++){
                        if (maquinas[i].Id == idBandaTransportadora){
                            Console.WriteLine("El ID ingresado ya existe. No se puede registrar la máquina.");
                            return;
                        }
                    }
                    Console.WriteLine("Ingrese el nombre de la máquina: ");
                    string nombreBandaTransportadora = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(nombreBandaTransportadora))
                    {
                        Console.WriteLine("El nombre no puede estar vacío. Ingrese nuevamente el nombre de la máquina: ");
                        nombreBandaTransportadora = Console.ReadLine() ?? "";
                    }
                    Console.WriteLine("Ingrese el modelo de la máquina: ");
                    string modeloBandaTransportadora = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(modeloBandaTransportadora))
                    {
                        Console.WriteLine("El modelo no puede estar vacío. Ingrese nuevamente el modelo de la máquina: ");
                        modeloBandaTransportadora = Console.ReadLine() ?? "";
                    }
                    Console.WriteLine("Ingrese la temperatura de la máquina: ");
                    int tempMaquinaBandaTransportadora;
                    while (!int.TryParse(Console.ReadLine(), out tempMaquinaBandaTransportadora) || tempMaquinaBandaTransportadora < 0)
                    {
                        Console.WriteLine("La temperatura no puede ser negativa. Ingrese nuevamente la temperatura de la máquina: ");
                    }
                    Console.WriteLine("Ingrese las horas de funcionamiento de la máquina: ");
                    int horasFuncionamientoBandaTransportadora;
                    while (!int.TryParse(Console.ReadLine(), out horasFuncionamientoBandaTransportadora) || horasFuncionamientoBandaTransportadora < 0)
                    {
                        Console.WriteLine("Las horas de funcionamiento no pueden ser negativas. Ingrese nuevamente las horas de funcionamiento de la máquina: ");
                    }
                    Console.WriteLine("Ingrese la cantidad de piezas producidas por la máquina: ");
                    int cantidadPiezasBandaTransportadora;
                    while (!int.TryParse(Console.ReadLine(), out cantidadPiezasBandaTransportadora) || cantidadPiezasBandaTransportadora < 0)
                    {
                        Console.WriteLine("La cantidad de piezas no puede ser negativa. Ingrese nuevamente la cantidad de piezas producidas por la máquina: ");
                    }
                    Console.WriteLine("Ingrese el estado de la máquina: ");
                    string estadoBandaTransportadora = Console.ReadLine() ?? "";
                    while (string.IsNullOrWhiteSpace(estadoBandaTransportadora))
                    {
                        Console.WriteLine("El estado no puede estar vacío. Ingrese nuevamente el estado de la máquina: ");
                        estadoBandaTransportadora = Console.ReadLine() ?? "";
                    }
                    while (!estadoBandaTransportadora.Equals("Operativa", StringComparison.OrdinalIgnoreCase) && 
                    !estadoBandaTransportadora.Equals("En mantenimiento", StringComparison.OrdinalIgnoreCase) && 
                    !estadoBandaTransportadora.Equals("Fuera de servicio", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Estado inválido. El estado debe ser 'Operativa', 'En mantenimiento' o 'Fuera de servicio'.");
                        Console.WriteLine("Ingrese el estado de la máquina: ");
                        estadoBandaTransportadora = Console.ReadLine() ?? "";
                    }
                    Console.WriteLine("Ingrese la velocidad de la banda: ");
                    double velocidadBanda;
                    while (!double.TryParse(Console.ReadLine(), out velocidadBanda) || velocidadBanda < 0)
                    {
                        Console.WriteLine("La velocidad de la banda no puede ser negativa. Ingrese nuevamente la velocidad de la banda: ");
                    }
                    Console.WriteLine("Ingrese la longitud de la banda: ");
                    double longitudBanda;
                    while (!double.TryParse(Console.ReadLine(), out longitudBanda) || longitudBanda < 0)
                    {
                        Console.WriteLine("La longitud de la banda no puede ser negativa. Ingrese nuevamente la longitud de la banda: ");
                    }
                    Console.WriteLine("Ingrese la capacidad de carga: ");
                    double capacidadCarga;
                    while (!double.TryParse(Console.ReadLine(), out capacidadCarga) || capacidadCarga < 0)
                    {
                        Console.WriteLine("La capacidad de carga no puede ser negativa. Ingrese nuevamente la capacidad de carga: ");
                    }
                    MaquinaIndustrial bandaTransportadora = new BandaTransportadora(idBandaTransportadora, nombreBandaTransportadora, modeloBandaTransportadora, tempMaquinaBandaTransportadora, horasFuncionamientoBandaTransportadora, cantidadPiezasBandaTransportadora, estadoBandaTransportadora, velocidadBanda, longitudBanda, capacidadCarga);
                    maquinas[totalMaquinas] = bandaTransportadora;
                    totalMaquinas++;
                    Console.WriteLine($"La máquina {nombreBandaTransportadora} ha sido registrada exitosamente.");
                    break;
    
            }
        }
        public  static void mostrarTodasLasMaquinas(MaquinaIndustrial[] maquinas, int totalMaquinas){
            if (totalMaquinas == 0){
                Console.WriteLine("No hay máquinas registradas.");
                return;
            }
            for (int i = 0; i < totalMaquinas; i++){
                Console.WriteLine($"Máquina {i + 1}:");
                maquinas[i].mostrarInformacion();
                Console.WriteLine("---------------------------");
            }
        }
        public static void monitoreoCondiciones(MaquinaIndustrial[] maquinas, int totalMaquinas){
            if (totalMaquinas == 0){
                Console.WriteLine("No hay máquinas registradas.");
                return;
            }
            Console.WriteLine("Ingrese el ID de la máquina a monitorear: ");
            int idMonitoreo;
            while (!int.TryParse(Console.ReadLine(), out idMonitoreo) || idMonitoreo <= 0)
            {
                Console.WriteLine("El ID debe ser un número positivo. Ingrese nuevamente el ID de la máquina: ");
            }
            int index = -1;
            for (int i = 0; i < totalMaquinas; i++){
                if (maquinas[i].Id == idMonitoreo){ 
                    index = i;
                    if(maquinas[index].TempMaquina < 60){
                        Console.WriteLine("La temeperatura de la maquina " + maquinas[index].Nombre + " esta Normal");
                    } else if(maquinas[index].TempMaquina > 60 && maquinas[index].TempMaquina < 80){
                        Console.WriteLine("Adertencia. La temeperatura de la maquina " + maquinas[index].Nombre + " esta alta");
                    }else{  
                        Console.WriteLine("Critica. La Temperatura de la maquina " + maquinas[index].Nombre + " esta demasiado alta");
                    }     
                }
            }
            if(index == -1){
                Console.WriteLine("No se encontró una máquina con el ID proporcionado.");
            }
        }
        public static void cambioEstadoMaquina(MaquinaIndustrial[] maquinas, int totalMaquinas){
            if (totalMaquinas == 0){
                Console.WriteLine("No hay máquinas registradas.");
                return;
            }
            Console.WriteLine("Ingrese el ID de la máquina a cambiar de estado: ");
            int idCambioEstado;
            while (!int.TryParse(Console.ReadLine(), out idCambioEstado) || idCambioEstado <= 0)
            {
                Console.WriteLine("El ID debe ser un número positivo. Ingrese nuevamente el ID de la máquina: ");
            }
            int index = -1;
            for (int i = 0; i < totalMaquinas; i++){
                if (maquinas[i].Id == idCambioEstado){ 
                    index = i;
                    break;
                }
            }
            if(index == -1){
                Console.WriteLine("No se encontró una máquina con el ID proporcionado.");
                return;
            }
            Console.WriteLine("Ingrese el nuevo estado de la máquina (Operativa, En mantenimiento, Fuera de servicio): ");
            string nuevoEstado = Console.ReadLine() ?? "";
            while(!nuevoEstado.Equals("Operativa", StringComparison.OrdinalIgnoreCase) && 
                  !nuevoEstado.Equals("En mantenimiento", StringComparison.OrdinalIgnoreCase) && 
                  !nuevoEstado.Equals("Fuera de servicio", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Estado inválido. El estado debe ser 'Operativa', 'En mantenimiento' o 'Fuera de servicio'.");
                Console.WriteLine("Ingrese el nuevo estado de la máquina: ");
                nuevoEstado = Console.ReadLine() ?? "";
            }
            maquinas[index].Estado = nuevoEstado;
            Console.WriteLine($"El estado de la máquina {maquinas[index].Nombre} ha sido cambiado a {nuevoEstado}.");
        }
        public static void establecerIntervaloMantenimiento(MaquinaIndustrial[] maquinas, int totalMaquinas){
            if (totalMaquinas == 0){
                Console.WriteLine("No hay máquinas registradas.");
                return;
            }
            Console.WriteLine("Ingrese el ID de la máquina para establecer el intervalo de mantenimiento: ");
            int horasFaltantes;
            int idMantenimiento;
            while (!int.TryParse(Console.ReadLine(), out idMantenimiento) || idMantenimiento <= 0)
            {
                Console.WriteLine("El ID debe ser un número positivo. Ingrese nuevamente el ID de la máquina: ");
            }
            int index = -1;
            for (int i = 0; i < totalMaquinas; i++){
                if (maquinas[i].Id == idMantenimiento){ 
                    index = i;
                    break;
                }
            }
            if(index == -1){
                Console.WriteLine("No se encontró una máquina con el ID proporcionado.");
                return;
            }
            Console.WriteLine("Ingrese el  intervalo de mantenimiento en horas: ");
            int nuevoIntervalo;
            while (!int.TryParse(Console.ReadLine(), out nuevoIntervalo) || nuevoIntervalo <= 0)
            {
                Console.WriteLine("El intervalo de mantenimiento debe ser un número positivo. Ingrese nuevamente el intervalo de mantenimiento: ");
            }
            if (nuevoIntervalo < maquinas[index].HorasFuncionamiento){
                Console.WriteLine($"La maquina {maquinas[index].Nombre} neceita mantenimiento.");
                return;
            }else{
                Console.WriteLine($"La maquina {maquinas[index].Nombre} no neceita mantenimiento.");
                horasFaltantes = nuevoIntervalo - maquinas[index].HorasFuncionamiento;
                Console.WriteLine($"Faltan {horasFaltantes} horas para el mantenimiento de la maquina {maquinas[index].Nombre}.");
            }    
        }
        public static void modificarHorasFuncionamiento(MaquinaIndustrial[] maquinas, int totalMaquinas){
            if (totalMaquinas == 0){
                Console.WriteLine("No hay máquinas registradas.");
                return;
            }
            Console.WriteLine("Ingrese el ID de la máquina para modificar las horas de funcionamiento: ");
            int idHoras;
            while (!int.TryParse(Console.ReadLine(), out idHoras) || idHoras <= 0)
            {
                Console.WriteLine("El ID debe ser un número positivo. Ingrese nuevamente el ID de la máquina: ");
            }
            int index = -1;
            for (int i = 0; i < totalMaquinas; i++){
                if (maquinas[i].Id == idHoras){ 
                    index = i;
                    break;
                }
            }
            if(index == -1){
                Console.WriteLine("No se encontró una máquina con el ID proporcionado.");
                return;
            }
            Console.WriteLine("Ingrese las nuevas horas de funcionamiento: ");
            int nuevasHoras;
            while (!int.TryParse(Console.ReadLine(), out nuevasHoras) || nuevasHoras < 0){
                Console.WriteLine("Las horas de funcionamiento no pueden ser negativas. Ingrese nuevamente las horas de funcionamiento: ");
            }
            maquinas[index].HorasFuncionamiento = nuevasHoras;
            Console.WriteLine($"Las horas de funcionamiento de la máquina {maquinas[index].Nombre} han sido actualizadas a {nuevasHoras} horas.");
        }
        public static void buscarMaquinaPorId(MaquinaIndustrial[] maquinas, int totalMaquinas){
            if (totalMaquinas == 0){
                Console.WriteLine("No hay máquinas registradas.");
                return;
            }
            Console.WriteLine("Ingrese el ID de la máquina a buscar: ");
            int idBuscar;
            while (!int.TryParse(Console.ReadLine(), out idBuscar) || idBuscar <= 0)
            {
                Console.WriteLine("El ID debe ser un número positivo. Ingrese nuevamente el ID de la máquina: ");
            }
            int index = -1;
            for (int i = 0; i < totalMaquinas; i++){
                if (maquinas[i].Id == idBuscar){ 
                    index = i;
                    break;
                }
            }
            if(index == -1){
                Console.WriteLine("No se encontró una máquina con el ID proporcionado.");
                return;
            }
            maquinas[index].mostrarInformacion();
        }
        public static void buscarMaquinaPorEstado(MaquinaIndustrial[] maquinas, int totalMaquinas){
            if (totalMaquinas == 0){
                Console.WriteLine("No hay máquinas registradas.");
                return;
            }
            Console.WriteLine("Ingrese el estado de la máquina a buscar (Operativa, En mantenimiento, Fuera de servicio): ");
            string estadoBuscar = Console.ReadLine() ?? "";
            while(!estadoBuscar.Equals("Operativa", StringComparison.OrdinalIgnoreCase) && 
                  !estadoBuscar.Equals("En mantenimiento", StringComparison.OrdinalIgnoreCase) && 
                  !estadoBuscar.Equals("Fuera de servicio", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Estado inválido. El estado debe ser 'Operativa', 'En mantenimiento' o 'Fuera de servicio'.");
                Console.WriteLine("Ingrese el estado de la máquina a buscar: ");
                estadoBuscar = Console.ReadLine() ?? "";
            }
            bool encontrado = false;
            for (int i = 0; i < totalMaquinas; i++){
                if (maquinas[i].Estado.Equals(estadoBuscar, StringComparison.OrdinalIgnoreCase)){ 
                    maquinas[i].mostrarInformacion();
                    Console.WriteLine("---------------------------");
                    encontrado = true;
                }
            }
            if(!encontrado){
                Console.WriteLine($"No se encontraron máquinas con el estado '{estadoBuscar}'.");
            }
        }
        public static void mostarEstadisticas(MaquinaIndustrial[] maquinas, int totalMaquinas){
            if (totalMaquinas == 0){
                Console.WriteLine("No hay máquinas registradas.");
                return;
            }
            int operativas = 0;
            int mantenimiento = 0;
            int fueraServicio = 0;
            for (int i = 0; i < totalMaquinas; i++){
                switch (maquinas[i].Estado.ToLower()){
                    case "operativa":
                        operativas++;
                        break;
                    case "en mantenimiento":
                        mantenimiento++;
                        break;
                    case "fuera de servicio":
                        fueraServicio++;
                        break;
                }
            }
            Console.WriteLine($"Máquinas operativas: {operativas}");
            Console.WriteLine($"Máquinas en mantenimiento: {mantenimiento}");
            Console.WriteLine($"Máquinas fuera de servicio: {fueraServicio}");
        }
        public static int mostrarMenu(){
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Registrar máquina industrial");
            Console.WriteLine("2. Mostrar todas las máquinas");
            Console.WriteLine("3. Monitoreo de condiciones");
            Console.WriteLine("4. Cambio de estado de máquina");
            Console.WriteLine("5. Establecer intervalo de mantenimiento");
            Console.WriteLine("6. Modificar horas de funcionamiento");
            Console.WriteLine("7. Buscar máquina por ID");
            Console.WriteLine("8. Buscar máquina por estado");
            Console.WriteLine("9. Mostrar estadísticas");
            Console.WriteLine("10. Guardad datos en archivo");
            Console.WriteLine("11. Cargar datos desde archivo");
            Console.WriteLine("12. Salir");
            Console.WriteLine("Seleccione una opcion: ");
            int opcion;
            while(!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 12)
            {
                Console.WriteLine("Opción inválida. Por favor, ingrese un número válido (1-12  ): ");
            }
            return opcion;
        }
        public static void guardarDatos(MaquinaIndustrial[] maquinas, ref int totalMaquinas){
            using (StreamWriter writer = new StreamWriter("maquinas.txt")){
                for (int i = 0; i < totalMaquinas; i++){
                    // Datos generales de la máquina
                    string datos = maquinas[i].Id + "," +
                                maquinas[i].Nombre + "," +
                                maquinas[i].Modelo + "," +
                                maquinas[i].TempMaquina + "," +
                                maquinas[i].HorasFuncionamiento + "," +
                                maquinas[i].CantidadPiezas + "," +
                                maquinas[i].Estado;

                    // Identificar el tipo de máquina
                    if (maquinas[i] is TornoCNC torno){
                        datos = "TornoCNC," + datos +
                        "," + torno.VelocidadHusillo +
                        "," + torno.DiametroMaximo +
                        "," + torno.TipoHerramienta;
                    }
                    else if (maquinas[i] is Fresadora fresadora){
                        datos = "Fresadora," + datos +
                                "," + fresadora.VelocidadCorte +
                                "," + fresadora.NumeroEjes +
                                "," + fresadora.TipoFresa;
                    }
                    else if (maquinas[i] is BandaTransportadora banda){
                        datos = "BandaTransportadora," + datos +
                                "," + banda.VelocidadBanda +
                                "," + banda.LongitudBanda +
                                "," + banda.CapacidadCarga;
                    }
                    writer.WriteLine(datos);
                }
            }
            Console.WriteLine("Datos guardados exitosamente en el archivo 'maquinas.txt'.");
        }
        public static void CargarDatos(MaquinaIndustrial[] maquinas, ref int totalMaquinas){
            string archivo = "maquinas.txt";
            if (!File.Exists(archivo)){
                Console.WriteLine("El archivo no existe.");
                return;
            }
            using (StreamReader reader = new StreamReader(archivo)){
                string linea;
                while ((linea = reader.ReadLine()) != null){
                    // Comprobar que exista espacio en el arreglo
                    if (totalMaquinas >= maquinas.Length){
                        Console.WriteLine("Se alcanzó el límite de máquinas.");
                        break;
                    }
                    string[] datos = linea.Split(',');
                    try{
                        // Identificar el tipo de máquina
                        string tipo = datos[0];

                        // Atributos generales
                        int id = int.Parse(datos[1]);
                        string nombre = datos[2];
                        string modelo = datos[3];
                        int temperatura = int.Parse(datos[4]);
                        int horas = int.Parse(datos[5]);
                        int piezas = int.Parse(datos[6]);
                        string estado = datos[7];

                        MaquinaIndustrial maquina = null;

                        if (tipo == "TornoCNC"){
                            int velocidadHusillo = int.Parse(datos[8]);
                            double diametroMaximo = double.Parse(datos[9]);
                            string tipoHerramienta = datos[10];
                            maquina = new TornoCNC(id, nombre, modelo, temperatura, horas, piezas, estado, velocidadHusillo, diametroMaximo, 
                            tipoHerramienta);
                            }
                        else if (tipo == "Fresadora"){
                            double velocidadCorte = double.Parse(datos[8]);
                            int numeroEjes = int.Parse(datos[9]);
                            string tipoFresa = datos[10];
                            maquina = new Fresadora(id, nombre, modelo, temperatura, horas, piezas, estado, velocidadCorte, numeroEjes, tipoFresa);
                        }
                        else if (tipo == "BandaTransportadora"){
                            double velocidadBanda = double.Parse(datos[8]);
                            double longitudBanda = double.Parse(datos[9]);
                            double capacidadCarga = double.Parse(datos[10]);

                            maquina = new BandaTransportadora(id, nombre, modelo, temperatura, horas, piezas, estado, velocidadBanda, longitudBanda,
                                capacidadCarga);
                        }
                        else{
                            Console.WriteLine("Tipo de máquina desconocido: " + tipo);
                            continue;
                        }
                        maquinas[totalMaquinas] = maquina;
                        totalMaquinas++;
                    }catch (Exception ex){
                        Console.WriteLine("Error al cargar una máquina: " + ex.Message);
                    }
                }
            }
            Console.WriteLine("Datos cargados exitosamente.");
        }

    }

