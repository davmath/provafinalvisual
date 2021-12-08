using System;

namespace API.Models
{
    public class FolhaPagamento
    {//Construtor
        public FolhaPagamento() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Ano { get; set; }
        public string Mes { get; set; }  
        public double ValorHora { get; set; }
        public int HorasTrabalhadas { get; set; }
        public DateTime CriadoEm { get; set; }
        public Funcionario Funcionario { get; set; }
        public int FuncionarioId { get; set; }

        
    }
}