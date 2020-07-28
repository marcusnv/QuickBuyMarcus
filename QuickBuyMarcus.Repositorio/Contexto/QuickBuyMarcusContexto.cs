using Microsoft.EntityFrameworkCore;
using QuickBuyMarcus.Dominio.Entidades;
using QuickBuyMarcus.Dominio.ObjetoDeValor;
using QuickBuyMarcus.Repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyMarcus.Repositorio.Contexto
{
    public class QuickBuyMarcusContexto : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ItemPedido> ItensPedido { get; set; }
        public DbSet<FormaDePagamento> FormaPagamento { get; set; }

        public QuickBuyMarcusContexto(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///Referência as classes de mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
