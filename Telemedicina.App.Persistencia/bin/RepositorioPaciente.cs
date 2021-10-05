using System.Collections.Generic;
using System.linq;
using Telemedicina.App.Dominio;

namespace Telemedicina.App.Persistencia


{
    public class RepositorioPaciente:IRepositorioPaciente
    {
        /// <summary>
        ///Referencia al contexto de Paciente
        /// </summary>

        private readonly AppContext _appContext;
        /// <summary>
        ///Referencia al contexto de Paciente
        ///Metodo constructor utiliza
        ///inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name= "appContext" ></param>//

        public RepositorioPaciente(AppContext AppContext)
        {
            _appContext= AppContext;
        }

        Paciente IRepositorioPaciente.AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado= _appContext.Pacientes.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        } 
        void IRepositorioPaciente.DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado= _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if(pacienteEncontrado==null)
                return;
            _appContext.Pacientes.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        } 
        IEnumerable<Paciente> IRepositorioPaciente.GetAllPacientes()
        {
            return _appContext.Pacientes;
        }  
        Paciente IRepositorioPaciente.GetPaciente (int idPaciente)
        {
            return _appContext.Pacientes.FirstOrDefault(p => p.Id == idPaciente);
        } 
        Paciente IRepositorioPaciente.UpdatePaciente (Paciente paciente)
         {
            var pacienteEncontrado = _appContext.Pacientes.FirstOrDefault(p => p.Id == Id);
            if (pacienteEncontrado=null)
            {
                pacienteEncontrado.Nombres= paciente.Nombres;
                pacienteEncontrado.Apellidos= Paciente.Apellidos;
                pacienteEncontrado.NumeroTelefono= Paciente.NumeroTelefono;
                pacienteEncontrado.Genero= Paciente.Genero;
                pacienteEncontrado.FechaNacimiento= paciente.FechaNacimiento;
                pacienteEncontrado.Medico= paciente.Medico;
                pacienteEncontrado.Sintoma= paciente.Sintoma;
                pacienteEncontrado.CorreoElectronico= paciente.CorreoElectronico;
                pacienteEncontrado.Contraseña= paciente.Contraseña;
                pacienteEncontrado.Ciudad=  paciente.Ciudad;
                pacienteEncontrado.Encuesta= paciente.Encuesta;
                pacienteEncontrado.Especialidad= 
            
                _appContext.SaveChanges();
                return pacienteEncontrado;
            } 

        }  

     } 
 } 