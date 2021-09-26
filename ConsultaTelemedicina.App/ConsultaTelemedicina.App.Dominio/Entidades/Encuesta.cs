using System;

namespace ConsultaTelemedicina.App.Dominio
{
    public class Encuesta
    {
      public int ID{get;set;}
      public string DocumentoPaciente{get;set;}
      public string Nombre{get;set;}
      public string Apellido{get;set;}
      public string NumeroTelefono{get;set;}
      public string TipoPaciente{get;set;}
      public string Sintoma1{get;set;}
      public string Sintoma2{get;set;}
      public string Sintoma3{get;set;}
      public string OtroSintoma{get;set;}
    } 
}