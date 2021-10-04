using System;
namespace Telemedicina.App.Dominio
{
    /// <summary>Class <c>Paciente</c>
    /// Modela un Paciente que esta en atencion hospitalaria
    /// </summary>   

    public class Paciente : Persona 
    {
        
        public DateTime FechaNacimiento { get; set; } 
        /// Relacion entre Paciente y el medico asignada
        public Medico Medico {get; set; }
        /// Relacion entre Paciente y el Medico que lo atiende 
        public Sintomas Sintoma { get; set; }
        public String CorreoElectronico { get; set; }
        public String Contraseña { get; set; }
        public TipoPacientes Pacientes { get; set; } 
        /// <summary>
        ///  Referencia a la lista de sintomas de un Paciente 
        /// </summary>
        /// <value></value>
        public System.Collections.Generic.List<Sintomas> sintoma { get; set; }
    }
}
