using QuickBuyMarcus.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuyMarcus.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }

        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }
        public FormaDePagamento FormaDePagamento { get; set; }

        /// <summary>
        /// Pedido deve ter pelo menos 1 item de pedido ou muitos itens de pedidos
        /// </summary>
        public ICollection<ItemPedido> ItensPedido { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItensPedido.Any())
            {
                AdicionarCritica("Crítica: Pedido não pode estar vazio");
            }
            if (string.IsNullOrEmpty(CEP))
            {
                AdicionarCritica("Crítica: CEP deve estar preenchido");
            }
            if (FormaDePagamento.Id == 0)
            {
                AdicionarCritica("Crítica: Forma de pagamento não informada");
            }
        }
    }
}
