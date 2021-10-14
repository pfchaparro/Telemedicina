using System;
using System.Collections.Generic;
using System.Linq;
using Telemedicina.App.Dominio;

namespace CitasMedicas.App.Persistencia
{
     public class RepositorioMedico : IRepositorioMedico
     {
          private readonly AppContext _appContext = new AppContext();
          /*
          private readonly AppContext _appContext; //recomendable por seguridad
          public RepositorioMedico(AppContext appContext) 
          {
            _appContext=appContext; //Necesitamos definir un contexto
          }
          */
          Medico IRepositorioMedico.AddMedico(Medico medico)
          {
            var medicoAdicionado= _appContext.Medicos.Add(medico);
            _appContext.SaveChanges(); //Se deben guardar los cambios
            return medicoAdicionado.Entity; 
          }

          void IRepositorioMedico.DeleteMedico(int idMedico)
          {
            var medicoEncontrado= _appContext.Medicos.FirstOrDefault(p =>p.Id==idMedico);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if(medicoEncontrado==null)
            return;
            _appContext.Medicos.Remove(medicoEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios
          }

          IEnumerable <Medico> IRepositorioMedico.GetAllMedicos  ()
          {
            return _appContext.Medicos;
          }

        Medico IRepositorioMedico.GetMedico  (int idMedico)
          {
           return _appContext.Medicos.FirstOrDefault(p =>p.Id==idMedico);//retorna lo que encuentra
          }

        Medico IRepositorioMedico.UpdateMedico  (Medico medico)
          {
           var medicoEncontrado= _appContext.Medicos.FirstOrDefault(p =>p.Id==medico.Id);
           //No se busca el idMedico, se busca el medico.Id
           if(medicoEncontrado!=null)
           {
                medicoEncontrado.Id= medico.Id;
                medicoEncontrado.Genero= medico.Genero;
                medicoEncontrado.Nombres=medico.Nombres;
                medicoEncontrado.Apellidos=medico.Apellidos;
                medicoEncontrado.NumeroTelefono=medico.NumeroTelefono;
                medicoEncontrado.FechaNacimiento=medico.FechaNacimiento;
                medicoEncontrado.Cita=medico.Cita;
                medicoEncontrado.Codigo=medico.Codigo;
                medicoEncontrado.Especialidad=medico.Especialidad;
                medicoEncontrado.RegistroMedico=medico.RegistroMedico; 

                _appContext.SaveChanges();        
           }
             return medicoEncontrado; //retorna el medico encontrado
            
          }  
     }
} 