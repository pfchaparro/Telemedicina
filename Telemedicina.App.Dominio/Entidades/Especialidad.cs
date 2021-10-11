using System;

namespace Telemedicina.App.Dominio
{
    /// <summary>Class <c>Especialidad</c>
    /// Modela las especialidades del medico
    /// </summary>   
    public class Especialidad 
    {
        // Identificador único de cada sintoma
        public int Id { get; set; } 
        public TipoEspecialidad especialidades { get; set; } 
    }
}
