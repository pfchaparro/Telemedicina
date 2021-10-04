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
        public String Especialidad {get;set;} 

}
}