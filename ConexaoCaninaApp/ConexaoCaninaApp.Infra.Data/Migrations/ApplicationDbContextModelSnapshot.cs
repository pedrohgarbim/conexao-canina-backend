﻿// <auto-generated />
using System;
using ConexaoCaninaApp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConexaoCaninaApp.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Cao", b =>
                {
                    b.Property<int>("CaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CaoId"), 1L, 1);

                    b.Property<string>("CaracteristicasUnicas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("Genero")
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("ProprietarioId")
                        .HasColumnType("int");

                    b.Property<string>("Raca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Tamanho")
                        .HasColumnType("int");

                    b.HasKey("CaoId");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Caes");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Foto", b =>
                {
                    b.Property<int>("FotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FotoId"), 1L, 1);

                    b.Property<string>("CaminhoArquivo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CaoId")
                        .HasColumnType("int");

                    b.Property<int>("Ordem")
                        .HasColumnType("int");

                    b.HasKey("FotoId");

                    b.HasIndex("CaoId");

                    b.ToTable("Fotos");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.HistoricoSaude", b =>
                {
                    b.Property<int>("HistoricoSaudeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HistoricoSaudeId"), 1L, 1);

                    b.Property<int>("CaoId")
                        .HasColumnType("int");

                    b.Property<string>("CondicoesDeSaude")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("ConsentimentoDono")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Exame")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Vacinas")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HistoricoSaudeId");

                    b.HasIndex("CaoId");

                    b.ToTable("HistoricosDeSaude");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Localizacao", b =>
                {
                    b.Property<int>("LocalizacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocalizacaoId"), 1L, 1);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LocalizacaoId");

                    b.ToTable("Localizacoes");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Proprietario", b =>
                {
                    b.Property<int>("ProprietarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProprietarioId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocalizacaoId")
                        .HasColumnType("int");

                    b.Property<int?>("LocalizacaoId1")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProprietarioId");

                    b.HasIndex("LocalizacaoId")
                        .IsUnique();

                    b.HasIndex("LocalizacaoId1");

                    b.ToTable("Proprietarios");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Usuario", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("UsuarioId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Cao", b =>
                {
                    b.HasOne("ConexaoCaninaApp.Domain.Models.Proprietario", "Proprietario")
                        .WithMany("Caes")
                        .HasForeignKey("ProprietarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proprietario");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Foto", b =>
                {
                    b.HasOne("ConexaoCaninaApp.Domain.Models.Cao", "Cao")
                        .WithMany("Fotos")
                        .HasForeignKey("CaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cao");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.HistoricoSaude", b =>
                {
                    b.HasOne("ConexaoCaninaApp.Domain.Models.Cao", "Cao")
                        .WithMany("HistoricosDeSaude")
                        .HasForeignKey("CaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cao");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Proprietario", b =>
                {
                    b.HasOne("ConexaoCaninaApp.Domain.Models.Localizacao", "Localizacao")
                        .WithOne()
                        .HasForeignKey("ConexaoCaninaApp.Domain.Models.Proprietario", "LocalizacaoId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ConexaoCaninaApp.Domain.Models.Localizacao", null)
                        .WithMany("Proprietarios")
                        .HasForeignKey("LocalizacaoId1");

                    b.Navigation("Localizacao");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Cao", b =>
                {
                    b.Navigation("Fotos");

                    b.Navigation("HistoricosDeSaude");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Localizacao", b =>
                {
                    b.Navigation("Proprietarios");
                });

            modelBuilder.Entity("ConexaoCaninaApp.Domain.Models.Proprietario", b =>
                {
                    b.Navigation("Caes");
                });
#pragma warning restore 612, 618
        }
    }
}
