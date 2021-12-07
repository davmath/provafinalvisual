using System;

namespace API.Models
{
    public class FormasDePagamento
    {
        //Construtor
        public FormasDePagamento() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Tipo { get; set; }
        public int Parcelas { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}