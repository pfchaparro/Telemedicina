using System;
using Telemedicina.App.Dominio;
using Telemedicina.App.Persistencia;
using System.Collections.Generic;

namespace Telemedicina.App.Consola
{
    class Program
    {

        //private static IRepositorioPaciente _repoPaciente=new RepositorioPaciente(new Persistencia.AppContext());
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente();
        private static IRepositorioMedico _repoMedico=new RepositorioMedico();
        private static IRepositorioCita _repoCiudad=new RepositorioCita();

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos!");
            AddPaciente(); 
            AddMedico(); 
            AddCita();
        }

        private static void AddPaciente()
        {
            var paciente =new Paciente
            {
                Nombre="Karol",
                Apellidos="Ramirez",
                NumeroTelefono="456789",
                Genero=Genero.Femenino, 
                Ciudad="Pereira"
                CorreoElectronico= "KarolRamirez01@telemedicina.com"
                Contraseña= "123app"
            };
            _repoPaciente.AddPaciente(paciente);
        }
        
        private static void BuscarPaciente(int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine("Nombre: "+paciente.Nombres+" "+paciente.Apellidos+"  Género: "+paciente.Genero);
        }

        private static void MostrarPacientes(){
            IEnumerable<Paciente> pacientes = _repoPaciente.GetAllPacientes();
            foreach (var paciente in pacientes)
            {
                Console.WriteLine("Paciente: "+paciente.Nombres+" "+paciente.Apellidos);
            }

        }


        private static void AddMedico()
        {
            var medico =new Medico
            {
                Nombre="Catalina",
                Apellidos="Torres",
                NumeroTelefono="1234567",
                Genero=Genero.Femenino, 
                Especialidad="Ginecologia",
                Codigo="2345",
                RegistroMedico="RETHUS54321", 
            };
            _repoMedico.AddMedico(medico);
            Console.WriteLine("ingresamos el medico bien");
        }

        private static void BuscarMedico(int idMedico)
        {
            Console.WriteLine(" empieza a buscar el medico");
            var medico = _repoMedico.GetMedico(idMedico);
            Console.WriteLine("termina de buscar el medico");
            Console.WriteLine("Nombres: "+medico.Nombres); 
        }  

         


        private static void AddCita()
        {
            var cita=new Cita
            {
                IdCita= "1"
            };
            _repoCita.AddCita(cita);
        }







    }
}
