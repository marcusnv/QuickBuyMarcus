using System.Collections;
using System.Collections.Generic;

namespace QuickBuyMarcus.Dominio.Entidades
{
    public class Usuario : Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        /// <summary>
        /// Um usuário pode ter NENHUM ou MUITOS pedidos
        /// </summary>
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (string.IsNullOrEmpty(Email))
            {
                AdicionarCritica("Crítica: E-mail não informado");
            }

            if (string.IsNullOrEmpty(Senha))
            {
                AdicionarCritica("Crítica: Senha não foi informada");
            }
        }
    }
}
