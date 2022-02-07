using System;
using System.ComponentModel.DataAnnotations;

namespace Proeventos.API.Models
{
    public class Evento
    {   [Key]
        public int EventoId {get;set;}
        public string Nome{get;set;}
        public string Local{get;set;}
        public int Vagas{get;set;}
        public float ValorIngresso{get;set;}
        public bool Ativo{get;set;}
        public DateTime DataInicio{get;set;} = DateTime.Today;
    }
}