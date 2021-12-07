using System;

namespace API.Models
{
    public class ItemVenda
    {
        public ItemVenda() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public Funcionario Funcionario { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }
        public string CarrinhoId { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}