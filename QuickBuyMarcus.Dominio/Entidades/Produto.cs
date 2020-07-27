using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyMarcus.Dominio.Entidades
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
