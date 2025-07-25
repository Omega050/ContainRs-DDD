﻿// <auto-generated />
using System;
using ContainRs.Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContainRs.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContainRs.Clientes.Cadastro.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Celular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ContainRs.Clientes.Cadastro.EnderecoCliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Municipio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("EnderecoCliente");
                });

            modelBuilder.Entity("ContainRs.Engenharia.Conteineres.Conteiner", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Observacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Conteineres");
                });

            modelBuilder.Entity("ContainRs.Vendas.Locacoes.Locacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPrevistaEntrega")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataTermino")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PropostaId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PropostaId")
                        .IsUnique();

                    b.ToTable("Locacoes");
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.Comentario", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("PropostaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Texto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PropostaId");

                    b.ToTable("Comentario");
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.PedidoLocacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataInicioOperacao")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DisponibilidadePrevia")
                        .HasColumnType("int");

                    b.Property<int>("DuracaoPrevistaLocacao")
                        .HasColumnType("int");

                    b.Property<Guid>("EnderecoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Finalidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantidadeEstimada")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.Proposta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ClienteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataExpiracao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeArquivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("SolicitacaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("SolicitacaoId");

                    b.ToTable("Propostas");
                });

            modelBuilder.Entity("ContainRs.Clientes.Cadastro.Cliente", b =>
                {
                    b.OwnsOne("ContainRs.Clientes.Cadastro.Email", "Email", b1 =>
                        {
                            b1.Property<Guid>("ClienteId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Email");

                            b1.HasKey("ClienteId");

                            b1.ToTable("Clientes");

                            b1.WithOwner()
                                .HasForeignKey("ClienteId");
                        });

                    b.Navigation("Email")
                        .IsRequired();
                });

            modelBuilder.Entity("ContainRs.Clientes.Cadastro.EnderecoCliente", b =>
                {
                    b.HasOne("ContainRs.Clientes.Cadastro.Cliente", "Cliente")
                        .WithMany("Enderecos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ContainRs.Vendas.Locacoes.Locacao", b =>
                {
                    b.HasOne("ContainRs.Vendas.Propostas.Proposta", "Proposta")
                        .WithOne()
                        .HasForeignKey("ContainRs.Vendas.Locacoes.Locacao", "PropostaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("ContainRs.Vendas.Locacoes.StatusLocacao", "Status", b1 =>
                        {
                            b1.Property<Guid>("LocacaoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Status");

                            b1.HasKey("LocacaoId");

                            b1.ToTable("Locacoes");

                            b1.WithOwner()
                                .HasForeignKey("LocacaoId");
                        });

                    b.Navigation("Proposta");

                    b.Navigation("Status")
                        .IsRequired();
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.Comentario", b =>
                {
                    b.HasOne("ContainRs.Vendas.Propostas.Proposta", "Proposta")
                        .WithMany("Comentarios")
                        .HasForeignKey("PropostaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proposta");
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.PedidoLocacao", b =>
                {
                    b.OwnsOne("ContainRs.Vendas.Propostas.Endereco", "Localizacao", b1 =>
                        {
                            b1.Property<Guid>("PedidoLocacaoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("CEP")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<double>("Latitude")
                                .HasColumnType("float");

                            b1.Property<double>("Longitude")
                                .HasColumnType("float");

                            b1.Property<string>("Referencias")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("PedidoLocacaoId");

                            b1.ToTable("Pedidos");

                            b1.WithOwner()
                                .HasForeignKey("PedidoLocacaoId");
                        });

                    b.OwnsOne("ContainRs.Vendas.Propostas.StatusPedido", "Status", b1 =>
                        {
                            b1.Property<Guid>("PedidoLocacaoId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Status");

                            b1.HasKey("PedidoLocacaoId");

                            b1.ToTable("Pedidos");

                            b1.WithOwner()
                                .HasForeignKey("PedidoLocacaoId");
                        });

                    b.Navigation("Localizacao")
                        .IsRequired();

                    b.Navigation("Status")
                        .IsRequired();
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.Proposta", b =>
                {
                    b.HasOne("ContainRs.Vendas.Propostas.PedidoLocacao", "Solicitacao")
                        .WithMany("Propostas")
                        .HasForeignKey("SolicitacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("ContainRs.Vendas.Propostas.SituacaoProposta", "Situacao", b1 =>
                        {
                            b1.Property<Guid>("PropostaId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("Status")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Status");

                            b1.HasKey("PropostaId");

                            b1.ToTable("Propostas");

                            b1.WithOwner()
                                .HasForeignKey("PropostaId");
                        });

                    b.Navigation("Situacao")
                        .IsRequired();

                    b.Navigation("Solicitacao");
                });

            modelBuilder.Entity("ContainRs.Clientes.Cadastro.Cliente", b =>
                {
                    b.Navigation("Enderecos");
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.PedidoLocacao", b =>
                {
                    b.Navigation("Propostas");
                });

            modelBuilder.Entity("ContainRs.Vendas.Propostas.Proposta", b =>
                {
                    b.Navigation("Comentarios");
                });
#pragma warning restore 612, 618
        }
    }
}
