using System;

namespace ConsultaTelemedicina.App.Dominio
{
    public class Consulta
    {
      public int ID{get;set;}
      public date Fecha{get;set;}
      public time Horario{get;set;}
      public string Ciudad{get;set;}
      public string DocumentoPaciente{get;set;}
      public string DocumentoMedico{get;set;}
      public int IDEncuesta{get;set;}
      public boolean Modalidad{get;set;}
      public int Valor{get;set;} 
    } 
}
