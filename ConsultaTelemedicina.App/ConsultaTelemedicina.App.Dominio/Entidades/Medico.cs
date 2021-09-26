using System;

namespace ConsultaTelemedicina.App.Dominio
{
    public class Medico : Persona
    {
      public int ID {get;set;}
      public string Nombre{get;set;}
      public string Apellido{get;set;}
      public string DocumentoMedico{get;set;}
      public Genero Genero{get;set;}
      public string NumeroTelefono{get;set;}
      public string FechaNacimiento{get;set;} 
      public int IDEspecialidad{get;set;}
       } 
}