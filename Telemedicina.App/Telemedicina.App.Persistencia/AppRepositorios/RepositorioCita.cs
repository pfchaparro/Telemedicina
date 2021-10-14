using System;
using System.Collections.Generic;
using System.Linq;
using Telemedicina.App.Dominio;

namespace Telemedicina.App.Persistencia
{
     public class RepositorioCita : IRepositorioCita
     {

          private readonly AppContext _appContext = new AppContext();

          Cita IRepositorioCita.AddCita(Cita cita) 
          {
            var citaAdicionado= _appContext.Citas.Add(cita);
            _appContext.SaveChanges(); 
            return citaAdicionado.Entity; 
          }

          void IRepositorioCita.DeleteCita(int idCita)
          {
            var citaEncontrado= _appContext.Citas.FirstOrDefault(p =>p.Id==idCita);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if(citaEncontrado==null)
            return;
            _appContext.Citas.Remove(citaEncontrado);
            _appContext.SaveChanges();
          }

          IEnumerable <Cita> IRepositorioCita.GetAllCitas ()
          {
            return _appContext.Citas;
             
          }

        Cita IRepositorioCita.GetCita  (int idCita)
          {
           return _appContext.Citas.FirstOrDefault(p =>p.Id==idCita);//retorna lo que encuentra
          }

        Cita IRepositorioCita.UpdateCita (Cita cita)
          {
           var citaEncontrado= _appContext.Citas.FirstOrDefault(p =>p.Id==cita.Id);
            
           if(citaEncontrado!=null)
           {
                citaEncontrado.IdCita=cita.IdCita;
                
                _appContext.SaveChanges();        
           }
             return citaEncontrado; 
            
 }
   }
           }