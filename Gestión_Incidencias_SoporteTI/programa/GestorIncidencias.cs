using System;
public class GestorIncidencias{
    private Incidencia[] incidencias;
    private int totalIncidencias;
    
    public GestorIncidencias(){
        incidencias = new Incidencia[20];
        totalIncidencias = 0;    
    }
    public void RegistrarIncidencia(Incidencia incidencia){
        if(totalIncidencias >= incidencias.Length){
                throw new InvalidOperationException("No se pueden registrar más incidencias.");
        }
        if(incidencia == null){
            throw new ArgumentNullException(nameof(incidencia), "La incidencia no puede ser nula.");
        }
        incidencias[totalIncidencias] = incidencia;
        totalIncidencias++;
    }
    public void MostrarTodasLasIncidencias(){
        Console.WriteLine("INCIDENCIAS REGISTRADAS:");
        Console.WriteLine("--------------------");
        for(int i = 0; i < totalIncidencias; i++){
            incidencias[i].mostrarInformacion();
            Console.WriteLine("--------------------");
        }
    }
    public void BuscarPorIdentificador(){
        if(totalIncidencias == 0){
            Console.WriteLine("No hay incidencias registradas para buscar.");
            return;
        }
        Console.WriteLine("Ingrese el identificador de la incidencia a buscar:");
        string identificador = Console.ReadLine();
        while(string.IsNullOrEmpty(identificador)){
            Console.WriteLine("El identificador no puede estar vacío. Ingrese nuevamente:");
            identificador = Console.ReadLine();
        }
        bool encontrado = false;
        for(int i = 0; i < totalIncidencias; i++){
            if(incidencias[i].Identificador == identificador){
                incidencias[i].mostrarInformacion();
                encontrado = true;
                break;
            }
        }
        if(!encontrado){
            Console.WriteLine("No se encontró ninguna incidencia con el identificador proporcionado.");
        }
    }
    public void BuscarPorEmpleado(){
        if(totalIncidencias == 0){
            Console.WriteLine("No hay incidencias registradas para filtrar por empleado.");
            return;
        }
        Console.WriteLine("Ingrese el nombre del empleado para buscar incidencias:");
        string nombreEmpleado = Console.ReadLine();
        while(string.IsNullOrWhiteSpace(nombreEmpleado)){
            Console.WriteLine("El nombre del empleado no puede estar vacío. Ingrese nuevamente:");
            nombreEmpleado = Console.ReadLine();
        }
        bool encontrado = false;
        for(int i = 0; i < totalIncidencias; i++){
            if(incidencias[i].NombreEmpleado().Equals(nombreEmpleado, StringComparison.OrdinalIgnoreCase)){
                incidencias[i].mostrarInformacion();
                encontrado = true;
            }
        }
        if(!encontrado){
            Console.WriteLine("No se encontraron incidencias para el empleado proporcionado.");
        }
    }
    public void FiltrarPorPrioridad(){
        if(totalIncidencias == 0){
            Console.WriteLine("No hay incidencias registradas para filtrar por prioridad.");
            return;
        }
        Console.WriteLine("Ingrese la prioridad para filtrar incidencias (Alta, Media, Baja, Critica):");
        string prioridad = Console.ReadLine();
        while(string.IsNullOrWhiteSpace(prioridad)){
            Console.WriteLine("La prioridad no puede estar vacía. Ingrese nuevamente:");
            prioridad = Console.ReadLine();
        }
        bool encontrado = false;
        for(int i = 0; i < totalIncidencias; i++){
            if(incidencias[i].Prioridad.Equals(prioridad, StringComparison.OrdinalIgnoreCase)){
                incidencias[i].mostrarInformacion();
                encontrado = true;
            }
        }
        if(!encontrado){
            Console.WriteLine("No se encontraron incidencias con la prioridad proporcionada.");
        }
    }
    public void FiltrarPorEstado(){
        if(totalIncidencias == 0){
            Console.WriteLine("No hay incidencias registradas para filtrar por estado.");
            return;
        }
        Console.WriteLine("Ingrese el estado para filtrar incidencias (Abierta, En Proceso, Resuelta):");
        string estado = Console.ReadLine();
        while(string.IsNullOrWhiteSpace(estado)){
            Console.WriteLine("El estado no puede estar vacío. Ingrese nuevamente:");
            estado = Console.ReadLine();
        }
        bool encontrado = false;
        for(int i = 0; i < totalIncidencias; i++){
            if(incidencias[i].Estado.Equals(estado, StringComparison.OrdinalIgnoreCase)){
                incidencias[i].mostrarInformacion();
                encontrado = true;
            }
        }
        if(!encontrado){
            Console.WriteLine("No se encontraron incidencias con el estado proporcionado.");
        }
    }
    public void FiltrarPorTipo(){
        if(totalIncidencias == 0){
            Console.WriteLine("No hay incidencias registradas para filtrar por tipo.");
            return;
        }
        Console.WriteLine("Ingrese el tipo de incidencia para filtrar (Hardware, Software, Red):");
        string tipo = Console.ReadLine();
        while(string.IsNullOrWhiteSpace(tipo)){
            Console.WriteLine("El tipo de incidencia no puede estar vacío. Ingrese nuevamente:");
            tipo = Console.ReadLine();
        }
        bool encontrado = false;
        for(int i = 0; i < totalIncidencias; i++){
            if(incidencias[i].GetType().Name.Equals("Incidencia" + tipo, StringComparison.OrdinalIgnoreCase)){
                incidencias[i].mostrarInformacion();
                encontrado = true;
            }
        }
        if(!encontrado){
            Console.WriteLine("No se encontraron incidencias del tipo proporcionado.");
        }
    }
    public void CambiarEstado(){
        if(totalIncidencias == 0){
            Console.WriteLine("No hay incidencias registradas para cambiar su estado.");
            return;
        }
        Console.WriteLine("Ingrese el identificador de la incidencia cuyo estado desea cambiar:");
        string identificador = Console.ReadLine();
        while(string.IsNullOrWhiteSpace(identificador)){
            Console.WriteLine("El identificador no puede estar vacío. Ingrese nuevamente:");
            identificador = Console.ReadLine();
        }
        bool encontrado = false;
        for(int i = 0; i < totalIncidencias; i++){
            if(incidencias[i].Identificador.Equals(identificador, StringComparison.OrdinalIgnoreCase)){
                encontrado = true;
                Console.WriteLine("Ingrese el nuevo estado para la incidencia (Abierta, En Proceso, Resuelta):");
                string nuevoEstado = Console.ReadLine();
                while(string.IsNullOrWhiteSpace(nuevoEstado)){
                    Console.WriteLine("El estado no puede estar vacío. Ingrese nuevamente:");
                    nuevoEstado = Console.ReadLine();
                }
                if(nuevoEstado != "Abierta" && nuevoEstado != "En Proceso" && nuevoEstado != "Resuelta"){
                    Console.WriteLine("El estado ingresado no es válido. Debe ser 'Abierta', 'En Proceso' o 'Resuelta'.");
                    return;
                }

                if(incidencias[i].Estado.Equals(nuevoEstado, StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine("El estado ingresado es el mismo que el actual. No se realizaron cambios.");
                    return;
                }
                if(incidencias[i].Estado.Equals("Resuelta", StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine("No se puede cambiar el estado de una incidencia que ya ha sido resuelta.");
                    return;
                }
               if(incidencias[i].Estado.Equals("Abierta", StringComparison.OrdinalIgnoreCase) && nuevoEstado.Equals("Resuelta", StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine("No se puede cambiar directamente de 'Abierta' a 'Resuelta'. Primero debe pasar por 'En Proceso'.");
                    return;
                }
                if(incidencias[i].Estado.Equals("Abierta", StringComparison.OrdinalIgnoreCase) && nuevoEstado.Equals("En Proceso", StringComparison.OrdinalIgnoreCase)){
                    incidencias[i].Estado = nuevoEstado;
                    Console.WriteLine("El estado de la incidencia ha sido cambiado a 'En Proceso'.");
                    return;
                }
                if(incidencias[i].Estado.Equals("En Proceso", StringComparison.OrdinalIgnoreCase) && nuevoEstado.Equals("Abierta", StringComparison.OrdinalIgnoreCase)){
                    Console.WriteLine("No se puede cambiar de 'En Proceso' a 'Abierta'.");
                    return;
                }
                if(incidencias[i].Estado.Equals("En Proceso", StringComparison.OrdinalIgnoreCase) && nuevoEstado.Equals("Resuelta", StringComparison.OrdinalIgnoreCase)){
                    incidencias[i].Estado = nuevoEstado;
                    Console.WriteLine("El estado de la incidencia ha sido cambiado a 'Resuelta'.");               
                    return;
                }    
                break;
            }
        }
        if(!encontrado){
            Console.WriteLine("No se encontró ninguna incidencia con el identificador proporcionado.");
        }
    }
    public void MostrarTotalIncidencias(){
        if(totalIncidencias == 0){
            Console.WriteLine("No hay incidencias registradas.");
            return;
        }
        Console.WriteLine($"Total de incidencias registradas: {totalIncidencias}");
    }
    public void MostrarEstadisticasPorEstado(){
        if(totalIncidencias == 0){
            Console.WriteLine("No hay incidencias registradas para mostrar estadísticas.");
            return;
        }
        int abiertas = 0, enProceso = 0, resueltas = 0;
        for(int i = 0; i < totalIncidencias; i++){
            switch(incidencias[i].Estado.ToLower()){
                case "abierta":
                    abiertas++;
                    break;
                case "en proceso":
                    enProceso++;
                    break;
                case "resuelta":
                    resueltas++;
                    break;
            }
        }
        Console.WriteLine("ESTADÍSTICAS DE INCIDENCIAS POR ESTADO:");
        Console.WriteLine($"Abiertas: {abiertas}");
        Console.WriteLine($"En Proceso: {enProceso}");
        Console.WriteLine($"Resueltas: {resueltas}");
    }
    public void MostrarEstadisticasPorPrioridad(){
        if(totalIncidencias == 0){
            Console.WriteLine("No hay incidencias registradas para mostrar estadísticas.");
            return;
        }
        int alta = 0, media = 0, baja = 0, critica = 0;
        for(int i = 0; i < totalIncidencias; i++){
            switch(incidencias[i].Prioridad.ToLower()){
                case "alta":
                    alta++;
                    break;
                case "media":
                    media++;
                    break;
                case "baja":
                    baja++;
                    break;
                case "critica":
                    critica++;
                    break;
            }
        }
        Console.WriteLine("ESTADÍSTICAS DE INCIDENCIAS POR PRIORIDAD:");
        Console.WriteLine($"Alta: {alta}");
        Console.WriteLine($"Media: {media}");
        Console.WriteLine($"Baja: {baja}");
        Console.WriteLine($"Crítica: {critica}");
    }
    public void MostrarEstadisticasPorTipo(){
        if(totalIncidencias == 0){
            Console.WriteLine("No hay incidencias registradas para mostrar estadísticas.");
            return;
        }
        int hardware = 0, software = 0, red = 0;
        for(int i = 0; i < totalIncidencias; i++){
            switch(incidencias[i].GetType().Name.ToLower()){
                case "incidenciahardware":
                    hardware++;
                    break;
                case "incidenciasoftware":
                    software++;
                    break;
                case "incidenciared":
                    red++;
                    break;
            }
        }
        Console.WriteLine("ESTADÍSTICAS DE INCIDENCIAS POR TIPO:");
        Console.WriteLine($"Hardware: {hardware}");
        Console.WriteLine($"Software: {software}");
        Console.WriteLine($"Red: {red}");
    }
    public void MostrarPorcentajePorEstado(){
        if(totalIncidencias == 0){
            Console.WriteLine("No hay incidencias registradas para mostrar estadísticas.");
            return;
        }
        int abiertas = 0, enProceso = 0, resueltas = 0;
        for(int i = 0; i < totalIncidencias; i++){
            switch(incidencias[i].Estado.ToLower()){
                case "abierta":
                    abiertas++;
                    break;
                case "en proceso":
                    enProceso++;
                    break;
                case "resuelta":
                    resueltas++;
                    break;
            }
        }
        Console.WriteLine("PORCENTAJE DE INCIDENCIAS POR ESTADO:");
        Console.WriteLine($"Abiertas: {(double)abiertas / totalIncidencias * 100:F2}%");
        Console.WriteLine($"En Proceso: {(double)enProceso / totalIncidencias * 100:F2}%");
        Console.WriteLine($"Resueltas: {(double)resueltas / totalIncidencias * 100:F2}%");
    }
    public void MostrarResumenEstadistico(){
        if(totalIncidencias == 0){
            Console.WriteLine("No hay incidencias registradas para mostrar estadísticas.");
            return;
        }
        MostrarEstadisticasPorEstado();
        MostrarEstadisticasPorPrioridad();
        MostrarEstadisticasPorTipo();
        MostrarPorcentajePorEstado();
    }
    public void mostrarmenu(){
    
    }
    
}
