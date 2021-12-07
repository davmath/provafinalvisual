using System;
using System.Collections.Generic;

namespace API.Models
{
    public class Venda
    {
        public Venda() => CriadoEm = DateTime.Now;
        public int Id { get; set; }
        public string Cliente { get; set; }
        public List<ItemVenda> Itens { get; set; }
        public DateTime CriadoEm { get; set; }

        public Funcionario Funcionario { get; set; }
        public int ProdutoId { get; set; }

        public ItemVenda ItemVenda { get; set; }
        public int ItemVendaId { get; set; }

        public FormasDePagamento FormasDePagamento { get; set; }
        public int FormasDePagamentoId { get; set; }
    }
}