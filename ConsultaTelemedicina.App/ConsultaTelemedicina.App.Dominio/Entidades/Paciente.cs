using System;

namespace ConsultaTelemedicina.App.Dominio
{
    public class Paciente : Persona
    {
      public int ID {get;set;}
      public string Nombre{get;set;}
      public string Apellido{get;set;}
      public string Documento{get;set;}
      public Genero Genero{get;set;}
      public string NumeroTelefono{get;set;}
      public string FechaNacimiento{get;set;} 
      public string CorreoElectronico{get;set;}
      public string Contraseña{get;set;} 
      public int TipoPaciente{get;set;} 
       } 
}