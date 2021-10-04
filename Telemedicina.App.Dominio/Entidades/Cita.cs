using System;
namespace Telemedicina.App.Dominio
{
     /// <summary>Class <c>Cita</c>
    /// Modela la cita con los respectivos datos
    /// </summary>  
    public class Cita 
    {

        public int Id { get; set; }  
        public DateTime FechaHora { get; set; } 
        public String Modalidad { get; set; }
        public String PrecioConsulta{ get; set; }

    }
}
