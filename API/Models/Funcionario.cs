using System;

namespace API.Models
{
    public class Funcionario
    {
        //Construtor
        public Funcionario() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }
        public string CPF { get; set; }
        public int Idade { get; set; }
        public DateTime CriadoEm { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }

        public override string ToString() =>
            $"Nome: {Nome} | Preço: {Salario.ToString("C2")} | Criado em: {CriadoEm}";
    }
}