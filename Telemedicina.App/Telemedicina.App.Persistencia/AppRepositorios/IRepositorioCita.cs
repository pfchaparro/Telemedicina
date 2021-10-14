using System;
using System.Collections.Generic;
using Telemedicina.App.Dominio;

namespace Telemedicina.App.Persistencia
{
    public interface IRepositorioCita
    {
       IEnumerable<Cita> GetAllCitas();
        Cita AddCita(Cita cita);
        Cita UpdateCita(Cita cita);
        void DeleteCita(int idCita);
        Cita GetCita (int idCita);
         
    }
}