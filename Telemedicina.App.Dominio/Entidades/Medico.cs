using System;
namespace Telemedicina.App.Dominio
{ 
    ///<summary>Class <c> Medico</c>
    /// Modela un Medico del equipo medico de apoyo
    ///<summary>

    public class Medico: Persona
{ 
        //Codigo unico del medico 
        public String Codigo {get;set;}
        //Regitro unico nacional del talento humano
        public string RegistroRethus {get;set;} 
         //Nombre de la especialidad medica 
        public String Especialidad {get;set;} 

}
}