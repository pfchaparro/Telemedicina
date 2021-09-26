using System;

namespace ConsultaTelemedicina.App.Dominio
{
    public class Factura
    {
      public int ID {get;set;}
      public string Nombre{get;set;} 
      public string Afiliacion{get;set;}  
      public date Fecha{get;set;}
      public time Horario{get;set;}
      public string DocumentoPaciente{get;set;}
      public string NumeroTelefono{get;set;}
      public string CorreoElectronico{get;set;}
      public string Sede{get;set;}
      public string Valor{get;set;}
      public boolean Descuento{get;set;}
       } 
}