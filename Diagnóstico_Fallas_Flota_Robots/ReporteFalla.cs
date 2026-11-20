using System;
    public class ReporteFalla{
        private int idReporte;
        private int idRobot;
        private DateTime fecha;
        private string descripcion = string.Empty;
        private string severidad = string.Empty;
        private string estadoReporte = string.Empty;
        private string solucion = string.Empty;
        
        public int IdReporte{
            get{
                return idReporte;
            }
            set{
                if(value <= 0){
                    throw new ArgumentException("El ID debe ser mayor que cero.");
                }
                idReporte = value;
            }
        }
        public int IdRobot{
            get{
                return idRobot;
            }
            set{
                if(value <= 0){
                    throw new ArgumentException("El ID del Robot no puede ser negativo.");
                }
                idRobot = value;
            }
        }
        public DateTime  Fecha{
            get{
                return fecha;
            }
            set{
                if (value == DateTime.MinValue){
                    throw new ArgumentException("La fecha del reporte no es válida.");
                    }
                    fecha = value;
            }
        }
        public string Descripcion{
            get{
                return descripcion;
            }
            set{
                if(string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentException("La descripcion no puede estar vacía.");
                }
                descripcion = value.Trim();
            }
        }
        public string Severidad{
            get{
                return severidad;
            }
            set{
                if (string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentException("La severidad no puede estar vacía.");
                }
                string valor = value.Trim();
                if (!valor.Equals("Baja", StringComparison.OrdinalIgnoreCase) && !valor.Equals("Media", StringComparison.OrdinalIgnoreCase) &&
                !valor.Equals("Alta", StringComparison.OrdinalIgnoreCase) && !valor.Equals("Crítica", StringComparison.OrdinalIgnoreCase)){
                    throw new ArgumentException("Severidad no válida. Utiliza Baja, Media, Alta o Crítica.");
                }
                severidad = valor.ToLower() == "crítica" ? "Crítica" : char.ToUpper(valor[0]) + valor.Substring(1).ToLower();
            }
        }
        public string EstadoReporte{
            get{
                return estadoReporte;
            }
            set{
                if (string.IsNullOrWhiteSpace(value)){
                    throw new ArgumentException("El estado del reporte no puede estar vacío.");
                }
                string valor = value.Trim();
                if (!valor.Equals("Pendiente", StringComparison.OrdinalIgnoreCase) && !valor.Equals("En revisión", StringComparison.OrdinalIgnoreCase) &&
                !valor.Equals("Resuelto", StringComparison.OrdinalIgnoreCase)){
                    throw new ArgumentException("Estado no válido. Utiliza Pendiente, En revisión o Resuelto.");
                }
                if (valor.Equals("Pendiente", StringComparison.OrdinalIgnoreCase)){
                estadoReporte = "Pendiente";
                }else if (valor.Equals("En revisión", StringComparison.OrdinalIgnoreCase)){
                estadoReporte = "En revisión";
                }else{
                estadoReporte = "Resuelto";
                }
            }
        }
        public string Solucion{
            get{
                return solucion;
            }
            set{
                solucion = value.Trim();
            }
        }
        public ReporteFalla(int idReporte, int idRobot,DateTime fecha, string descripcion, string severidad,
        string estadoReporte, string solucion){
        
        IdReporte = idReporte;
        IdRobot = idRobot;
        Fecha = fecha;
        Descripcion = descripcion;
        Severidad = severidad;
        EstadoReporte = estadoReporte;
        Solucion = solucion;

        }
        public void MostrarReporte(){
            Console.WriteLine("===== REPORTE DE FALLA =====");
            Console.WriteLine($"ID del reporte: {IdReporte}");
            Console.WriteLine($"ID del robot: {IdRobot}");
            Console.WriteLine($"Fecha: {Fecha:dd/MM/yyyy HH:mm}");
            Console.WriteLine($"Descripción: {Descripcion}");
            Console.WriteLine($"Severidad: {Severidad}");
            Console.WriteLine($"Estado: {EstadoReporte}");
            Console.WriteLine($"Solución: {Solucion}");
        }
    }
