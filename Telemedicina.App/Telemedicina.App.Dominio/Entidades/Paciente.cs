using System;
namespace Telemedicina.App.Dominio
{
    /// <summary>Class <c>Paciente</c>
    /// Modela un Paciente que esta en atencion hospitalaria
    /// </summary>   

    public class Paciente : Persona 
    {
        
        
        
        public String CorreoElectronico { get; set; }
        public String Contraseña { get; set; } 
        /// <summary>
        ///  Referencia a la lista de sintomas de un Paciente 
        /// </summary>
        /// <value></value>
        public System.Collections.Generic.List<Sintoma> sintomas { get; set; }
    }
}
