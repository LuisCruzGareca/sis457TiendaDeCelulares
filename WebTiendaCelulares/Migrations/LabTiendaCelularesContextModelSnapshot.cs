﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebTiendaCelulares.Models;

#nullable disable

namespace WebTiendaCelulares.Migrations
{
    [DbContext(typeof(LabTiendaCelularesContext))]
    partial class LabTiendaCelularesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WebTiendaCelulares.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descripcion");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PK__categori__3213E83FD9A82C6C");

                    b.ToTable("categorias", (string)null);
                });

            modelBuilder.Entity("WebTiendaCelulares.Models.Celulare", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("descripcion");

                    b.Property<DateTime>("FechaCreacion")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(6)
                        .HasColumnType("datetime2(6)")
                        .HasColumnName("fecha_creacion")
                        .HasDefaultValueSql("(sysdatetime())");

                    b.Property<DateTime>("FechaModificacion")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(6)
                        .HasColumnType("datetime2(6)")
                        .HasColumnName("fecha_modificacion")
                        .HasDefaultValueSql("(sysdatetime())");

                    b.Property<int?>("IdCategoria")
                        .HasColumnType("int")
                        .HasColumnName("idCategoria");

                    b.Property<int?>("IdColor")
                        .HasColumnType("int")
                        .HasColumnName("idColor");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("marca");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("modelo");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)")
                        .HasColumnName("nombre");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("precio");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__celulare__3213E83FD7733505");

                    b.HasIndex("IdCategoria");

                    b.HasIndex("IdColor");

                    b.ToTable("celulares", (string)null);
                });

            modelBuilder.Entity("WebTiendaCelulares.Models.Colore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("nombre");

                    b.HasKey("Id")
                        .HasName("PK__colores__3213E83FB0CA302D");

                    b.ToTable("colores", (string)null);
                });

            modelBuilder.Entity("WebTiendaCelulares.Models.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("DireccionEnvio")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("direccion_envio");

                    b.Property<DateTime>("FechaVenta")
                        .ValueGeneratedOnAdd()
                        .HasPrecision(6)
                        .HasColumnType("datetime2(6)")
                        .HasColumnName("fecha_venta")
                        .HasDefaultValueSql("(sysdatetime())");

                    b.Property<int?>("IdCelular")
                        .HasColumnType("int")
                        .HasColumnName("idCelular");

                    b.Property<int?>("IdUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id_usuario")
                        .HasDefaultValueSql("(NULL)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(10, 2)")
                        .HasColumnName("total");

                    b.HasKey("Id")
                        .HasName("PK__compras__3213E83F8AFA8E1D");

                    b.HasIndex("IdCelular");

                    b.HasIndex("IdUsuario");

                    b.ToTable("compras", (string)null);
                });

            modelBuilder.Entity("WebTiendaCelulares.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("email");

                    b.Property<string>("Nombre")
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("nombre");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(45)
                        .IsUnicode(false)
                        .HasColumnType("varchar(45)")
                        .HasColumnName("password");

                    b.HasKey("Id")
                        .HasName("PK__usuarios__3213E83F189C6714");

                    b.ToTable("usuarios", (string)null);
                });

            modelBuilder.Entity("WebTiendaCelulares.Models.Celulare", b =>
                {
                    b.HasOne("WebTiendaCelulares.Models.Categoria", "IdCategoriaNavigation")
                        .WithMany("Celulares")
                        .HasForeignKey("IdCategoria")
                        .HasConstraintName("FK_celulares_categorias");

                    b.HasOne("WebTiendaCelulares.Models.Colore", "IdColorNavigation")
                        .WithMany("Celulares")
                        .HasForeignKey("IdColor")
                        .HasConstraintName("FK_celulares_colores");

                    b.Navigation("IdCategoriaNavigation");

                    b.Navigation("IdColorNavigation");
                });

            modelBuilder.Entity("WebTiendaCelulares.Models.Compra", b =>
                {
                    b.HasOne("WebTiendaCelulares.Models.Celulare", "IdCelularNavigation")
                        .WithMany("Compras")
                        .HasForeignKey("IdCelular")
                        .HasConstraintName("FK_compras_celulares");

                    b.HasOne("WebTiendaCelulares.Models.Usuario", "IdUsuarioNavigation")
                        .WithMany("Compras")
                        .HasForeignKey("IdUsuario")
                        .HasConstraintName("FK__compras__id_usua__4AB81AF0");

                    b.Navigation("IdCelularNavigation");

                    b.Navigation("IdUsuarioNavigation");
                });

            modelBuilder.Entity("WebTiendaCelulares.Models.Categoria", b =>
                {
                    b.Navigation("Celulares");
                });

            modelBuilder.Entity("WebTiendaCelulares.Models.Celulare", b =>
                {
                    b.Navigation("Compras");
                });

            modelBuilder.Entity("WebTiendaCelulares.Models.Colore", b =>
                {
                    b.Navigation("Celulares");
                });

            modelBuilder.Entity("WebTiendaCelulares.Models.Usuario", b =>
                {
                    b.Navigation("Compras");
                });
#pragma warning restore 612, 618
        }
    }
}
