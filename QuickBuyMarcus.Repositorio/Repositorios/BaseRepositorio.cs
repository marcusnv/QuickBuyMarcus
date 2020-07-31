using QuickBuyMarcus.Dominio.Contratos;
using QuickBuyMarcus.Repositorio.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuyMarcus.Repositorio.Repositorios
{
    public class BaseRepositorio<TEntity> : IBaseRepositorio<TEntity> where TEntity : class
    {
        protected readonly QuickBuyMarcusContexto QuickBuyMarcusContexto;

        public BaseRepositorio(QuickBuyMarcusContexto quickBuyMarcusContexto)
        {
            QuickBuyMarcusContexto = quickBuyMarcusContexto;
        }
        public void Adicionar(TEntity entity)
        {
            QuickBuyMarcusContexto.Set<TEntity>().Add(entity);
            QuickBuyMarcusContexto.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            QuickBuyMarcusContexto.Set<TEntity>().Update(entity);
            QuickBuyMarcusContexto.SaveChanges();
        }

        public void Dispose()
        {
            QuickBuyMarcusContexto.Dispose();
        }

        public TEntity ObterPorId(int id)
        {
            return QuickBuyMarcusContexto.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return QuickBuyMarcusContexto.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            QuickBuyMarcusContexto.Set<TEntity>().Remove(entity);
            QuickBuyMarcusContexto.SaveChanges();
        }
    }
}
