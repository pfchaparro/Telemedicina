using System;
namespace Telemedicina.App.Dominio
{
    public class Sede
    {
        
        public int Id{get;set;}
        public string NombreSede{get;set;}

        public Ciudad Ciudad{get;set;}
    }
}