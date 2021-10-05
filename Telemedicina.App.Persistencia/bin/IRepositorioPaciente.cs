using System.Collections.Generic;
using Telemedicina.App.Dominio;

namespace Telemedicina.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();

        Paciente AddPaciente(Paciente paciente);

        Paciente UpdatePaciente (Paciente paciente);

        Void DeletePaciente (int idPaciente);

        Paciente GetPaciente (int idPaciente);

    }
}