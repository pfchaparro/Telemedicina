using System;
namespace Telemedicina.App.Dominio
{ 
    ///<summary>Class <c> Persona</c>
    ///Modelar una persona en general para el sistema
    ///<summary>

    public class Persona
    { 
        public int Id {get;set;}
        public String Nombres {get;set;}
        public String Apellidos {get;set;}
        public String NumeroTelefono {get;set;}
        //Genero de la persona
        public Genero Genero {get;set;}

}
    }