using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuyMarcus.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuyMarcus.Repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            //Builder utiliza o padrão fluent
            builder
                .Property(p => p.CEP)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.Cidade)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.DataPedido)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.DataPrevisaoEntrega)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(p => p.Estado)
                .IsRequired()
                .HasMaxLength(50);

 


        }
    }
}
