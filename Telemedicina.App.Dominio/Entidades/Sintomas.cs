using System;

namespace Telemedicina.App.Dominio
{
    /// <summary>Class <c>Sintoma</c>
    /// Modela los sintomas del Paciente
    /// </summary>   
    public class Sintomas 
    {
        // Identificador único de cada sintoma
        public int Id { get; set; } 
        public TipoSintoma Sintoma{ get; set; } 
    }
}