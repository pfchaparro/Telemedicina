using System;
namespace Telemedicina.App.Dominio
{
    /// <summary>
    /// Modela la encuesta a aplicar al paciente
    /// </summary>

    public class Encuesta : Paciente
    {
        // Idntificador unico de la encuesta
        public int Id { get; set; } 
        public TipoSintoma Sintomas { get; set; } 
        public TipoPacientes Pacientes { get; set; } 
        public TipoEspecialidad Especialidades { get; set; } 


    }
}