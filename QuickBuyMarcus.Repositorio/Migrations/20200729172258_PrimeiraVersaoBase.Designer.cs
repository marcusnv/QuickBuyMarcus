﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuickBuyMarcus.Repositorio.Contexto;

namespace QuickBuyMarcus.Repositorio.Migrations
{
    [DbContext(typeof(QuickBuyMarcusContexto))]
    [Migration("20200729172258_PrimeiraVersaoBase")]
    partial class PrimeiraVersaoBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("QuickBuyMarcus.Dominio.Entidades.ItemPedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("PedidoId");

                    b.Property<int>("ProdutoId");

                    b.Property<int>("Quantidade");

                    b.HasKey("Id");

                    b.HasIndex("PedidoId");

                    b.ToTable("ItensPedido");
                });

            modelBuilder.Entity("QuickBuyMarcus.Dominio.Entidades.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("DataPedido");

                    b.Property<DateTime>("DataPrevisaoEntrega");

                    b.Property<string>("EnderecoCompleto")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("FormaDePagamentoId");

                    b.Property<int>("FormaPagamentoId");

                    b.Property<int>("NumeroEndereco");

                    b.Property<int>("UsuarioId");

                    b.HasKey("Id");

                    b.HasIndex("FormaDePagamentoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("QuickBuyMarcus.Dominio.Entidades.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("Preco");

                    b.HasKey("Id");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("QuickBuyMarcus.Dominio.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("QuickBuyMarcus.Dominio.ObjetoDeValor.FormaDePagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("FormaPagamento");
                });

            modelBuilder.Entity("QuickBuyMarcus.Dominio.Entidades.ItemPedido", b =>
                {
                    b.HasOne("QuickBuyMarcus.Dominio.Entidades.Pedido")
                        .WithMany("ItensPedido")
                        .HasForeignKey("PedidoId");
                });

            modelBuilder.Entity("QuickBuyMarcus.Dominio.Entidades.Pedido", b =>
                {
                    b.HasOne("QuickBuyMarcus.Dominio.ObjetoDeValor.FormaDePagamento", "FormaDePagamento")
                        .WithMany()
                        .HasForeignKey("FormaDePagamentoId");

                    b.HasOne("QuickBuyMarcus.Dominio.Entidades.Usuario", "Usuario")
                        .WithMany("Pedidos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
