﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuyMarcus.Dominio.Entidades
{
    //Classe abstrata - ñenhuma outra classe por instancia-la
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }

        public string ObterMensagensValidacao()
        {
            return string.Join(". ", mensagemValidacao);
        }

        public abstract void Validate();
        public bool EValido
        {
            get { return !mensagemValidacao.Any(); }
        }
    }
}
