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
}
