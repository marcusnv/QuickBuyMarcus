using QuickBuyMarcus.Dominio.Contratos;
using QuickBuyMarcus.Dominio.Entidades;
using QuickBuyMarcus.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyMarcus.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(QuickBuyMarcusContexto quickBuyMarcusContexto) : base(quickBuyMarcusContexto)
        {
        }
    }
}
