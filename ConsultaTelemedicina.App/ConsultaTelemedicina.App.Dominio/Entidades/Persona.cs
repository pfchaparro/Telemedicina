using System;

namespace ConsultaTelemedicina.App.Dominio
{
    public class Persona
    {
        public int ID {get;set}
        public Genero Genero {get;set} 
        public string Documento{get;set;}
        public string Nombre {get;set}
        public string Apellidos {get;set}
        public string NumeroTelefono {get;set}
        public string FechaNacimiento {get;set}

    }
}
