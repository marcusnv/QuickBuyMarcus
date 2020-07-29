using QuickBuyMarcus.Dominio.Contratos;
using QuickBuyMarcus.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyMarcus.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        private readonly QuickBuyMarcusContexto _quickBuyMarcusContexto;

        public BaseRepositorio(QuickBuyMarcusContexto quickBuyMarcusContexto)
        {
            _quickBuyMarcusContexto = quickBuyMarcusContexto;
        }
        public void Adicionar(TEntity entity)
        {
            _quickBuyMarcusContexto.Set<TEntity>().Add(entity);
        }

        public void Atualizar(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public TEntity ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public void Remover(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
