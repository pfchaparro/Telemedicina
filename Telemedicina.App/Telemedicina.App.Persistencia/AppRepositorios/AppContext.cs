using Microsoft.EntityFrameworkCore;
using Telemedicina.App.Dominio;


namespace Telemedicina.App.Persistencia
{ 
    public class AppContext: DbContext
    { 
        public DbSet <Persona> Personas   {get; set; }
         public DbSet <Medico> Medicoss   {get; set; }
          public DbSet <Paciente> Pacientess   {get; set; }
           public DbSet <Especialidad> especialidades   {get; set; }
            public DbSet <Sintoma> Sintomas  {get; set; }
             public DbSet <Cita> citas  {get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
       {
           if (!optionsBuilder.IsConfigured)
           {
               optionsBuilder
               .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = ConsultaTelemedicinaData");
           }
       }
   
   }
  
 }
  