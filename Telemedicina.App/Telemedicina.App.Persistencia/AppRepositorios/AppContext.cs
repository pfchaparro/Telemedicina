using Microsoft.EntityFrameworkCore; 
using Telemedicina.App.Dominio;

namespace Telemedicina.App.Persistencia
{
   public class AppContext : DbContext
   {
       public DbSet <Persona> Personas {get;set;}
       public DbSet <Paciente> Pacientes {get;set;}
       public DbSet <Medico> Medicos {get;set;}
       public DbSet <Cita> Citas{get;set;}
       public DbSet <Encuesta> Encuestas {get;set;}
       public DbSet <Especialidad> Especialidades {get;set;}
       public DbSet <Genero> Generos {get;set;}
       public DbSet <Sede> Sedes {get;set;}
       public DbSet <Sintoma> Sintomas{get;set;}
       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           if (!optionsBuilder.IsConfigured)
           {
               optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = TelemedicinaData");
           }
       }
   }   
}