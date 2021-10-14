using Microsoft.EntityFrameworkCore; 
using ConsultaTelemedicina.App.Dominio;

namespace ConsultaTelemedicina.App.Persistencia
{
   public class AppContext : DbContext
   {
       public DbSet<Persona> Personas{get;set;}
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
 