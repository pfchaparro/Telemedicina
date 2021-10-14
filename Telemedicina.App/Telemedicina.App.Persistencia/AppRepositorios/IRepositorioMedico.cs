using System.Collections.Generic;
using Telemedicina.App.Dominio;
namespace Telemedicina.App.Persistencia
{
    public interface IRepositorioMedico
    {
        IEnumerable<Medico> GetAllMedicos();
        Medico AddMedico(Medico medico);
        Medico UpdateMedico(Medico medico);
        void DeleteMedico(int idMedico);
        Medico GetMedico (int idMedico);
   }
}