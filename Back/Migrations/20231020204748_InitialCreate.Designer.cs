﻿// <auto-generated />
using System;
using Back;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Back.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231020204748_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Back.Clases.Ingredientes", b =>
                {
                    b.Property<int>("IdIngredientes")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdIngredientes"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OpcionIdOpcion")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdIngredientes");

                    b.HasIndex("OpcionIdOpcion");

                    b.ToTable("ingredientes");
                });

            modelBuilder.Entity("Back.Clases.IngredientesOpcion", b =>
                {
                    b.Property<int>("IdOpcion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdOpcion"));

                    b.Property<int>("IdIngredientes")
                        .HasColumnType("int");

                    b.HasKey("IdOpcion");

                    b.ToTable("ingredientesOpciones");
                });

            modelBuilder.Entity("Back.Clases.Opcion", b =>
                {
                    b.Property<int>("IdOpcion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdOpcion"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PedidoIdPedido")
                        .HasColumnType("int");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdOpcion");

                    b.HasIndex("PedidoIdPedido");

                    b.ToTable("opciones");
                });

            modelBuilder.Entity("Back.Clases.OpcionPedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPedido"));

                    b.Property<int>("IdOpcion")
                        .HasColumnType("int");

                    b.Property<int>("OpcionIdOpcion")
                        .HasColumnType("int");

                    b.Property<int>("PedidoIdPedido")
                        .HasColumnType("int");

                    b.HasKey("IdPedido");

                    b.HasIndex("OpcionIdOpcion");

                    b.HasIndex("PedidoIdPedido");

                    b.ToTable("opcionesPedidos");
                });

            modelBuilder.Entity("Back.Clases.Pedido", b =>
                {
                    b.Property<int>("IdPedido")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdPedido"));

                    b.Property<bool>("Cargado")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReporteIdReporte")
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.HasKey("IdPedido");

                    b.HasIndex("ReporteIdReporte");

                    b.ToTable("pedidos");
                });

            modelBuilder.Entity("Back.Clases.Reporte", b =>
                {
                    b.Property<int>("IdReporte")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReporte"));

                    b.Property<DateTime>("FechaFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaRealizado")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Usuarioid")
                        .HasColumnType("int");

                    b.HasKey("IdReporte");

                    b.HasIndex("Usuarioid");

                    b.ToTable("reporte");
                });

            modelBuilder.Entity("Back.Clases.ReportePedido", b =>
                {
                    b.Property<int>("IdReporte")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdReporte"));

                    b.Property<int>("IdPedido")
                        .HasColumnType("int");

                    b.Property<int>("pedidoIdPedido")
                        .HasColumnType("int");

                    b.Property<int>("reporteIdReporte")
                        .HasColumnType("int");

                    b.HasKey("IdReporte");

                    b.HasIndex("pedidoIdPedido");

                    b.HasIndex("reporteIdReporte");

                    b.ToTable("reportePedidos");
                });

            modelBuilder.Entity("Back.Clases.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Contraseña")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Validate")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("Back.Clases.Ingredientes", b =>
                {
                    b.HasOne("Back.Clases.Opcion", null)
                        .WithMany("Ingredientes")
                        .HasForeignKey("OpcionIdOpcion");
                });

            modelBuilder.Entity("Back.Clases.Opcion", b =>
                {
                    b.HasOne("Back.Clases.Pedido", null)
                        .WithMany("OpcionesPedido")
                        .HasForeignKey("PedidoIdPedido");
                });

            modelBuilder.Entity("Back.Clases.OpcionPedido", b =>
                {
                    b.HasOne("Back.Clases.Opcion", "Opcion")
                        .WithMany()
                        .HasForeignKey("OpcionIdOpcion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Back.Clases.Pedido", "Pedido")
                        .WithMany()
                        .HasForeignKey("PedidoIdPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Opcion");

                    b.Navigation("Pedido");
                });

            modelBuilder.Entity("Back.Clases.Pedido", b =>
                {
                    b.HasOne("Back.Clases.Reporte", null)
                        .WithMany("Pedidos")
                        .HasForeignKey("ReporteIdReporte");
                });

            modelBuilder.Entity("Back.Clases.Reporte", b =>
                {
                    b.HasOne("Back.Clases.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Usuarioid");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Back.Clases.ReportePedido", b =>
                {
                    b.HasOne("Back.Clases.Pedido", "pedido")
                        .WithMany()
                        .HasForeignKey("pedidoIdPedido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Back.Clases.Reporte", "reporte")
                        .WithMany()
                        .HasForeignKey("reporteIdReporte")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pedido");

                    b.Navigation("reporte");
                });

            modelBuilder.Entity("Back.Clases.Opcion", b =>
                {
                    b.Navigation("Ingredientes");
                });

            modelBuilder.Entity("Back.Clases.Pedido", b =>
                {
                    b.Navigation("OpcionesPedido");
                });

            modelBuilder.Entity("Back.Clases.Reporte", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}
