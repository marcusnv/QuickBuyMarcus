using QuickBuyMarcus.Dominio.Contratos;
using QuickBuyMarcus.Dominio.Entidades;
using QuickBuyMarcus.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuyMarcus.Repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(QuickBuyMarcusContexto quickBuyMarcusContexto) : base(quickBuyMarcusContexto)
        {
        }

        public Usuario Obter(string email, string senha)
        {
            return QuickBuyMarcusContexto.Usuarios.FirstOrDefault(u => u.Email == email && u.Senha == senha);
        }

        public Usuario Obter(string email)
        {
            return QuickBuyMarcusContexto.Usuarios.FirstOrDefault(u => u.Email == email);
        }
    }
}
