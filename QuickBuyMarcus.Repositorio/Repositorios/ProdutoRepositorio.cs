using QuickBuyMarcus.Dominio.Contratos;
using QuickBuyMarcus.Dominio.Entidades;
using QuickBuyMarcus.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyMarcus.Repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(QuickBuyMarcusContexto quickBuyMarcusContexto) : base(quickBuyMarcusContexto)
        {

        }
    }
}
