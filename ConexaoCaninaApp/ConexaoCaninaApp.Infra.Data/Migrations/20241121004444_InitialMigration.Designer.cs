﻿// <auto-generated />
using System;
using ConexaoCaninaApp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConexaoCaninaApp.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241121004444_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Cao", b =>
                {
                    b.Property<Guid>("CaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CaracteristicasUnicas")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Raca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int>("Tamanho")
                        .HasColumnType("int");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("CaoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Caes");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Favorito", b =>
                {
                    b.Property<Guid>("FavoritoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("_caoId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CaoId");

                    b.HasKey("FavoritoId");

                    b.HasIndex("UsuarioId");

                    b.HasIndex("_caoId");

                    b.ToTable("Favoritos");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Foto", b =>
                {
                    b.Property<Guid>("FotoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CaminhoArquivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("CaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("FotoId");

                    b.HasIndex("CaoId");

                    b.ToTable("Fotos");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.HistoricoDeSaude", b =>
                {
                    b.Property<Guid>("HistoricoSaudeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("CaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CondicoesDeSaude")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("ConsentimentoDono")
                        .HasColumnType("bit");

                    b.Property<DateTime>("DataExame")
                        .HasColumnType("datetime2");

                    b.Property<string>("Exame")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Vacina")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("HistoricoSaudeId");

                    b.HasIndex("CaoId");

                    b.ToTable("HistoricosDeSaude");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Sugestao", b =>
                {
                    b.Property<Guid>("SugestaoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataEnvio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Feedback")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<Guid?>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SugestaoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Sugestoes");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Usuario", b =>
                {
                    b.Property<Guid>("UsuarioId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Cao", b =>
                {
                    b.HasOne("ConexaoCaninaApp.Domain.Models.Usuario", null)
                        .WithMany("Caes")
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("FK_Cao_Usuario");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Favorito", b =>
                {
                    b.HasOne("ConexaoCaninaApp.Domain.Models.Usuario", null)
                        .WithMany("Favoritos")
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("FK_Like_Usuario");

                    b.HasOne("ConexaoCaninaApp.Domain.Models.Cao", "Cao")
                        .WithMany()
                        .HasForeignKey("_caoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Favoritos_Cao");

                    b.Navigation("Cao");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Foto", b =>
                {
                    b.HasOne("ConexaoCaninaApp.Domain.Models.Cao", null)
                        .WithMany("Fotos")
                        .HasForeignKey("CaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_Foto_Cao");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.HistoricoDeSaude", b =>
                {
                    b.HasOne("ConexaoCaninaApp.Domain.Models.Cao", null)
                        .WithMany("HistoricosDeSaude")
                        .HasForeignKey("CaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("FK_HistoricoSaude_Cao");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Sugestao", b =>
                {
                    b.HasOne("ConexaoCaninaApp.Domain.Models.Usuario", null)
                        .WithMany("Sugestoes")
                        .HasForeignKey("UsuarioId")
                        .HasConstraintName("FK_Sugestao_Usuario");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Cao", b =>
                {
                    b.Navigation("Fotos");

                    b.Navigation("HistoricosDeSaude");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Usuario", b =>
                {
                    b.Navigation("Caes");

                    b.Navigation("Favoritos");

                    b.Navigation("Sugestoes");
                });
#pragma warning restore 612, 618
        }
    }
}
