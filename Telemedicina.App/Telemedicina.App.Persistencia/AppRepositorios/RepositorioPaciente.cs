 using System;
using System.Collections.Generic;
using System.Linq;
using Telemedicina.App.Dominio;

namespace Telemedicina.App.Persistencia
{
     public class RepositorioPaciente:IRepositorioPaciente
     {

          private readonly AppContext _appContext = new AppContext();

          Paciente IRepositorioPaciente.AddPaciente (Paciente paciente)
          {
            var pacienteAdicionado= _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();  
            return pacienteAdicionado.Entity; 
          }
 
          void IRepositorioPaciente.DeletePaciente(int idPaciente)
          {
            var pacienteEncontrado= _appContext.Pacientes.FirstOrDefault(p =>p.Id==idPaciente);//p es el primero que encuentra. Recorre todos los elementos de la tabla
            if(pacienteEncontrado==null)
            return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();//Se deben guardar los cambios
          }
            IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
          {
            return _appContext.Pacientes;
             
          }

        Paciente IRepositorioPaciente.GetPaciente  (int idPaciente)
          {
           return _appContext.Pacientes.FirstOrDefault(p =>p.Id==idPaciente); }

         Paciente IRepositorioPaciente.UpdatePaciente(Paciente paciente) 
          {
           var pacienteEncontrado= _appContext.Pacientes.FirstOrDefault(p =>p.Id==paciente.Id);
           
           if(pacienteEncontrado!=null)
           {
                
                pacienteEncontrado.Nombre = paciente.Nombre;
                pacienteEncontrado.Apellidos = paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono = paciente.NumeroTelefono;
                pacienteEncontrado.Genero = paciente.Genero;  
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                pacienteEncontrado.CorreoElectronico= paciente.CorreoElectronico;
                pacienteEncontrado.Contraseña = paciente.Contraseña;
                pacienteEncontrado.FechaNacimiento = paciente.FechaNacimiento;
                _appContext.SaveChanges();
           }
             return pacienteEncontrado; //retorna el paciente encontrado
            
          }
  
    ///Medico IRepositorioPaciente.AsignarMedico(int idPaciente, int idMedico)
       // {
         //   var pacienteEncontrado = _appContext.Pacientes.Find(idPaciente);
           // if (pacienteEncontrado != null)
            //{
              //  var medicoEncontrado = _appContext.Medicos.Find(idMedico);
                //if (medicoEncontrado != null)
                //{
                  //  pacienteEncontrado.Medico = medicoEncontrado;
                    //_appContext.SaveChanges();
               // }
               // return medicoEncontrado;
           // }
            //return null;
        //}
        //Sintoma IRepositorioPaciente.AsignarSintoma(int idPaciente, int idSintoma)
        //{
          //  var pacienteEncontrado = _appContext.Pacientes
            //.Where(p => p.Id == idPaciente)
            //.Include(p => p.Sintomas)
            //.SingleOrDefault();
            //if (pacienteEncontrado != null)
            //{
              //  var sintomaEncontrado = _appContext.Sintomas.Find(idSintoma);
                //if (sintomaEncontrado != null)
                //{
               //     pacienteEncontrado.Sintomas.Add(sintomaEncontrado);
                 //   _appContext.SaveChanges();
                //}
                //return sintomaEncontrado;
            }
           //return null;
         //}
    }
}
  
 