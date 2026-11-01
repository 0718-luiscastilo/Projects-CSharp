using System;
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
                    int idTorno = int.Parse(Console.ReadLine());
                    while (idTorno <= 0)
                    {
                        Console.WriteLine("El ID debe ser un número positivo. Ingrese nuevamente el ID de la máquina: ");
                        idTorno = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese el nombre de la máquina: ");
                    string nombreTorno = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(nombreTorno))
                    {
                        Console.WriteLine("El nombre no puede estar vacío. Ingrese nuevamente el nombre de la máquina: ");
                        nombreTorno = Console.ReadLine();
                    }
                    Console.WriteLine("Ingrese el modelo de la máquina: ");
                    string modeloTorno = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(modeloTorno))
                    {
                        Console.WriteLine("El modelo no puede estar vacío. Ingrese nuevamente el modelo de la máquina: ");
                        modeloTorno = Console.ReadLine();
                    }
                    Console.WriteLine("Ingrese la temperatura de la máquina: ");
                    int tempMaquinaTorno = int.Parse(Console.ReadLine());
                    while (tempMaquinaTorno < 0)
                    {
                        Console.WriteLine("La temperatura no puede ser negativa. Ingrese nuevamente la temperatura de la máquina: ");
                        tempMaquinaTorno = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese las horas de funcionamiento de la máquina: ");
                    int horasFuncionamientoTorno = int.Parse(Console.ReadLine());
                    while (horasFuncionamientoTorno < 0)
                    {
                        Console.WriteLine("Las horas de funcionamiento no pueden ser negativas. Ingrese nuevamente las horas de funcionamiento de la máquina: ");
                        horasFuncionamientoTorno = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese la cantidad de piezas producidas por la máquina: ");
                    int cantidadPiezasTorno = int.Parse(Console.ReadLine());
                    while (cantidadPiezasTorno < 0)
                    {
                        Console.WriteLine("La cantidad de piezas no puede ser negativa. Ingrese nuevamente la cantidad de piezas producidas por la máquina: ");
                        cantidadPiezasTorno = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese el estado de la máquina: ");
                    string estadoTorno = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(estadoTorno))
                    {
                        Console.WriteLine("El estado no puede estar vacío. Ingrese nuevamente el estado de la máquina: ");
                        estadoTorno = Console.ReadLine();
                    }
                    Console.WriteLine("Ingrese la velocidad del husillo: ");
                    int velocidadHusillo = int.Parse(Console.ReadLine());
                    while (velocidadHusillo < 0)
                    {
                        Console.WriteLine("La velocidad del husillo no puede ser negativa. Ingrese nuevamente la velocidad del husillo: ");
                        velocidadHusillo = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese el diámetro máximo: ");
                    double diametroMaximo = double.Parse(Console.ReadLine());
                    while (!double.TryParse(Console.ReadLine(), out double diametroMaximo) || diametroMaximo <= 0)
                    {
                        Console.WriteLine("El diámetro máximo debe ser un número positivo. Ingrese nuevamente el diámetro máximo: ");
                    }
                    
                    Console.WriteLine("Ingrese el tipo de herramienta: ");
                    string tipoHerramienta = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(tipoHerramienta))
                    {
                        Console.WriteLine("El tipo de herramienta no puede estar vacío. Ingrese nuevamente el tipo de herramienta: ");
                        tipoHerramienta = Console.ReadLine();
                    }   
                    
                    MaquinaIndustrial torno = new TornoCNC(idTorno, nombreTorno, modeloTorno, tempMaquinaTorno, horasFuncionamientoTorno, cantidadPiezasTorno, estadoTorno, velocidadHusillo, diametroMaximo, tipoHerramienta);
                    maquinas[totalMaquinas] = torno;
                    totalMaquinas++;
                    break;
                case 2:
                    Console.WriteLine("Ingrese el ID de la máquina: ");
                    int idFresadora = int.Parse(Console.ReadLine());
                    while (idFresadora <= 0)
                    {
                        Console.WriteLine("El ID debe ser un número positivo. Ingrese nuevamente el ID de la máquina: ");
                        idFresadora = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese el nombre de la máquina: ");
                    string nombreFresadora = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(nombreFresadora))
                    {
                        Console.WriteLine("El nombre no puede estar vacío. Ingrese nuevamente el nombre de la máquina: ");
                        nombreFresadora = Console.ReadLine();
                    }
                    Console.WriteLine("Ingrese el modelo de la máquina: ");
                    string modeloFresadora = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(modeloFresadora))
                    {
                        Console.WriteLine("El modelo no puede estar vacío. Ingrese nuevamente el modelo de la máquina: ");
                        modeloFresadora = Console.ReadLine();
                    }
                    Console.WriteLine("Ingrese la temperatura de la máquina: ");
                    int tempMaquinaFresadora = int.Parse(Console.ReadLine()); 
                    while (tempMaquinaFresadora < 0)
                    {
                        Console.WriteLine("La temperatura no puede ser negativa. Ingrese nuevamente la temperatura de la máquina: ");
                        tempMaquinaFresadora = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese las horas de funcionamiento de la máquina: ");
                    int horasFuncionamientoFresadora = int.Parse(Console.ReadLine());
                    while (horasFuncionamientoFresadora < 0)
                    {
                        Console.WriteLine("Las horas de funcionamiento no pueden ser negativas. Ingrese nuevamente las horas de funcionamiento de la máquina: ");
                        horasFuncionamientoFresadora = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese la cantidad de piezas producidas por la máquina: ");
                    int cantidadPiezasFresadora = int.Parse(Console.ReadLine());
                    while (cantidadPiezasFresadora < 0)
                    {
                        Console.WriteLine("La cantidad de piezas no puede ser negativa. Ingrese nuevamente la cantidad de piezas producidas por la máquina: ");
                        cantidadPiezasFresadora = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese el estado de la máquina: ");
                    string estadoFresadora = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(estadoFresadora))
                    {
                        Console.WriteLine("El estado no puede estar vacío. Ingrese nuevamente el estado de la máquina: ");
                        estadoFresadora = Console.ReadLine();
                    }
                    Console.WriteLine("Ingrese la velocidad de corte: ");
                    double velocidadCorte = double.Parse(Console.ReadLine());
                    while (velocidadCorte < 0)
                    {
                        Console.WriteLine("La velocidad de corte no puede ser negativa. Ingrese nuevamente la velocidad de corte: ");
                        velocidadCorte = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese el número de ejes: ");
                    int numeroEjes = int.Parse(Console.ReadLine());
                    while (numeroEjes <= 0)
                    {
                        Console.WriteLine("El número de ejes debe ser un número positivo. Ingrese nuevamente el número de ejes: ");
                        numeroEjes = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese el tipo de fresa: ");
                    string tipoFresa = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(tipoFresa))
                    {
                        Console.WriteLine("El tipo de fresa no puede estar vacío. Ingrese nuevamente el tipo de fresa: ");
                        tipoFresa = Console.ReadLine();
                    }

                    MaquinaIndustrial fresadora = new Fresadora(idFresadora, nombreFresadora, modeloFresadora, tempMaquinaFresadora, horasFuncionamientoFresadora, cantidadPiezasFresadora, estadoFresadora, velocidadCorte, numeroEjes, tipoFresa);
                    maquinas[totalMaquinas] = fresadora;
                    totalMaquinas++;
                    break;
                case 3:
                    Console.WriteLine("Ingrese el ID de la máquina: ");
                    int idBandaTransportadora = int.Parse(Console.ReadLine());
                    while (idBandaTransportadora <= 0)
                    {
                        Console.WriteLine("El ID debe ser un número positivo. Ingrese nuevamente el ID de la máquina: ");
                        idBandaTransportadora = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese el nombre de la máquina: ");
                    string nombreBandaTransportadora = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(nombreBandaTransportadora))
                    {
                        Console.WriteLine("El nombre no puede estar vacío. Ingrese nuevamente el nombre de la máquina: ");
                        nombreBandaTransportadora = Console.ReadLine();
                    }
                    Console.WriteLine("Ingrese el modelo de la máquina: ");
                    string modeloBandaTransportadora = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(modeloBandaTransportadora))
                    {
                        Console.WriteLine("El modelo no puede estar vacío. Ingrese nuevamente el modelo de la máquina: ");
                        modeloBandaTransportadora = Console.ReadLine();
                    }
                    Console.WriteLine("Ingrese la temperatura de la máquina: ");
                    int tempMaquinaBandaTransportadora = int.Parse(Console.ReadLine());
                    while (tempMaquinaBandaTransportadora < 0)
                    {
                        Console.WriteLine("La temperatura no puede ser negativa. Ingrese nuevamente la temperatura de la máquina: ");
                        tempMaquinaBandaTransportadora = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese las horas de funcionamiento de la máquina: ");
                    int horasFuncionamientoBandaTransportadora = int.Parse(Console.ReadLine());
                    while (horasFuncionamientoBandaTransportadora < 0)
                    {
                        Console.WriteLine("Las horas de funcionamiento no pueden ser negativas. Ingrese nuevamente las horas de funcionamiento de la máquina: ");
                        horasFuncionamientoBandaTransportadora = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese la cantidad de piezas producidas por la máquina: ");
                    int cantidadPiezasBandaTransportadora = int.Parse(Console.ReadLine());
                    while (cantidadPiezasBandaTransportadora < 0)
                    {
                        Console.WriteLine("La cantidad de piezas no puede ser negativa. Ingrese nuevamente la cantidad de piezas producidas por la máquina: ");
                        cantidadPiezasBandaTransportadora = int.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese el estado de la máquina: ");
                    string estadoBandaTransportadora = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(estadoBandaTransportadora))
                    {
                        Console.WriteLine("El estado no puede estar vacío. Ingrese nuevamente el estado de la máquina: ");
                        estadoBandaTransportadora = Console.ReadLine();
                    }
                    Console.WriteLine("Ingrese la velocidad de la banda: ");
                    double velocidadBanda = double.Parse(Console.ReadLine());
                    while (velocidadBanda < 0)
                    {
                        Console.WriteLine("La velocidad de la banda no puede ser negativa. Ingrese nuevamente la velocidad de la banda: ");
                        velocidadBanda = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese la longitud de la banda: ");
                    double longitudBanda = double.Parse(Console.ReadLine());
                    while (longitudBanda < 0)
                    {
                        Console.WriteLine("La longitud de la banda no puede ser negativa. Ingrese nuevamente la longitud de la banda: ");
                        longitudBanda = double.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Ingrese la capacidad de carga: ");
                    double capacidadCarga = double.Parse(Console.ReadLine());
                    while (capacidadCarga < 0)
                    {
                        Console.WriteLine("La capacidad de carga no puede ser negativa. Ingrese nuevamente la capacidad de carga: ");
                        capacidadCarga = double.Parse(Console.ReadLine());
                    }

                    MaquinaIndustrial bandaTransportadora = new BandaTransportadora(idBandaTransportadora, nombreBandaTransportadora, modeloBandaTransportadora, tempMaquinaBandaTransportadora, horasFuncionamientoBandaTransportadora, cantidadPiezasBandaTransportadora, estadoBandaTransportadora, velocidadBanda, longitudBanda, capacidadCarga);
                    maquinas[totalMaquinas] = bandaTransportadora;
                    totalMaquinas++;
                    break;
            }
        }

        
    }
